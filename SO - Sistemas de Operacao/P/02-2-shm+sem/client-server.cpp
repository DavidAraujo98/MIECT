#include <stdio.h>
#include <stdlib.h>
#include <libgen.h>
#include <unistd.h>
#include <sys/wait.h>
#include <sys/types.h>
#include <math.h>
#include <stdint.h>

#include "fifo.h"
#include "delays.h"
#include "process.h"

typedef struct ServiceRequest
{
    uint32_t clientid;
    char *frase;
} ServiceRequest;

typedef struct ServiceResponse
{
    uint32_t len = 0;
    uint32_t alpha = 0;
    uint32_t numbers = 0;
    uint32_t serverid = 0;
} ServiceResponse;

typedef struct SLOT
{
    int semid;
    ServiceRequest req;
    ServiceResponse res;
    bool hasResponse = false;
} SLOT;

int pending, free;

static void down(int semid, unsigned short index)
{
    struct sembuf op = {index, -1, 0};
    psemop(semid, &op, 1);
}

static void up(int semid, unsigned short index)
{
    struct sembuf op = {index, 1, 0};
    psemop(semid, &op, 1);
}

void callService(ServiceRequest &req, ServiceResponse &res)
{
    uint32_t id = retrive(&frees); /* take a buffer out of fifo of free buffers */
    mutex_lock(&slots[id].accessCR);

    /* put request data on buffer */
    slots[id].req = req;
    slots[id].res = res;
    insert(&pending, id); /* add buffer to fifo of pending requests */

    printf("Client %u call service\n", req.clientid);

    waitForResponse(id); /* wait (blocked) until a response is available */
    res = slots[id].res; /* take response out of buffer */

    printf("Size: %u,  Alpha: %u,  Numbers: %u,  ServerId: %u\n", res.len, res.alpha, res.numbers, res.serverid);

    mutex_unlock(&slots[id].accessCR);
    insert(&frees, id); /* buffer is free, so add it to fifo of free buffers */
}

void processService()
{
    for (i = slots[id].req.frase; *i != '\0'; i++)
    {
        slots[id].res.len++;
        if (isdigit(*i))
            slots[id].res.numbers++;
        if (isalpha(*i))
            slots[id].res.alpha++;
    }
}

// Create a Client Thread
void *client(void *arg)
{
    ServiceResponse res; //= new ServiceResponse();
    ServiceRequest req;  //= new ServiceRequest();
    req.clientid = x->id;
    req.frase = (char *)"Teste String 123";

    // Call the Service and wait for the response
    callService(req, res);
}

// Create a Server Thread
void *server(void *arg)
{
    while (1)
    {
        processService();
    }
}

