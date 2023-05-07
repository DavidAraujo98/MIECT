# Lab05

## Grupo - **P2G2**

| Membros | Número Mecanográfico |
| :- | :-: |
| David Araújo | 93444 |
| Miguel Nogueira | 93082 |

## Exercício 1

### a)
>π project.Pname, project.Pnumber, project.Plocation, project.Dnum, employee.Fname, employee.Lname, employee.Ssn works_on ⨝ Pno = Pnumber project ⨝ Ssn = Essn employee

```` SQL
SELECT project.*, employee.Fname, employee.Lname, employee.Ssn
FROM works_on
INNER JOIN project on Pno=Pnumber
INNER JOIN employee on Ssn=Essn
````

### b)
> π a.Fname, a.Minit, a.Lname, a.Ssn, a.Bdate, a.Address, a.Sex, a.Salary, a.Super_ssn, a.Dno ρ a employee ⨝ b.Ssn = a.Super_ssn ρ b π b.Ssn σ b.Fname = 'Carlos' and b.Lname = 'Gomes' ρ b employee

```` SQL
SELECT a.*
FROM employee AS a
INNER JOIN (
    SELECT b.Ssn
    FROM employee as b
    WHERE b.Fname='Carlos' AND b.Lname='Gomes')
AS b
ON b.Ssn = a.Super_ssn;
````

<div style="page-break-after: always;"></div>

### c)
>π project.Pname, a.Total project ⨝ a.Pno = Pnumber ρ a π Pno, Total γ Pno; SUM(Hours)→Total works_on
````SQL
SELECT project.Pname, a.Total
FROM project
INNER JOIN (
    SELECT Pno, SUM(Hours) AS Total
    FROM works_on
    GROUP BY Pno)
AS a
ON (a.Pno=Pnumber);
````

### d)
>π Fname, Minit, Lname employee ⨝ employee.Ssn = a.Essn ρ a π Essn works_on ⨝ works_on.Hours > 20 ρ b π Pnumber σ Pname = 'Aveiro Digital' project
````SQL
SELECT Fname, Minit, Lname
FROM employee
INNER JOIN (
    SELECT Essn
    FROM works_on
    INNER JOIN (
        SELECT Pnumber
        FROM project
        WHERE Pname='Aveiro Digital')
    AS b
    ON works_on.Hours > 20)
AS a
ON employee.Ssn = a.Essn
````

### e)
>π employee.Fname, employee.Minit, employee.Lname employee ⟕ Ssn = Essn works_on
````SQL
SELECT employee.Fname, employee.Minit, employee.Lname
FROM employee
LEFT JOIN works_on
ON Ssn=Essn
WHERE Essn IS NULL;
````

<div style="page-break-after: always;"></div>

### f)
>π department.Dname, AVGSalary, employee.Sex γ department.Dname, employee.Sex; AVG(employee.Salary)→AVGSalary department ⨝ employee.Dno = department.Dnumber employee
````SQL
SELECT department.Dname, AVG(employee.Salary) AS AVGSalary, employee.Sex
FROM department
INNER JOIN employee
ON employee.Dno=department.Dnumber
GROUP BY department.Dname, employee.Sex;
````

### g)
>π employee.Fname, employee.Minit, employee.Lname, e.Ndependents σ e.Ndependents > 2 employee ⨝ employee.Ssn = e.Essn ρ e π dependent.Essn, Ndependents γ Essn; COUNT(Essn)→Ndependents dependent
````SQL
SELECT employee.Fname, employee.Minit, employee.Lname, e.Ndependents
FROM employee
INNER JOIN (
 SELECT dependent.*, COUNT(Essn) AS Ndependents
 FROM dependent
 GROUP BY Essn
) AS e
ON employee.Ssn = e.Essn
WHERE e.Ndependents>2;
````

### h)
>π emp.Fname, emp.Minit, emp.Lname, emp.Ssn, department.Dname department ⨝ department.Mgr_ssn = emp.Ssn ρ emp π Fname, Minit, Lname, Ssn σ Essn = null employee ⟕ Essn = Ssn dependent
````SQL
SELECT emp.*, department.Dname
FROM department
INNER JOIN (
 SELECT Fname, Minit, Lname, Ssn
 FROM employee
 LEFT JOIN dependent
 ON Essn=Ssn
 WHERE Essn IS NULL
) 
AS emp
ON department.Mgr_ssn=emp.Ssn;
````

<div style="page-break-after: always;"></div>

### i)
>π wpre.Fname, wpre.Minit, wpre.Lname, wpre.Pname, wpre.Plocation, dept_location.Dlocation σ dept_location.Dlocation ≠ 'Aveiro' dept_location ⨝ wpre.Dno = dept_location.Dnumber ρ wpre π employee.Fname, employee.Minit, employee.Lname, employee.Dno, wpr.Pname, wpr.Plocation employee ⨝ wpr.Essn = employee.Ssn ρ wpr π Essn, proj.Plocation, proj.Pname works_on ⨝ works_on.Pno = proj.Pnumber ρ proj π Pnumber, Plocation, Pname σ Plocation = 'Aveiro' project
````SQL
SELECT wpre.Fname, wpre.Minit, wpre.Lname, wpre.Address
FROM dept_location
INNER JOIN (
    SELECT 
        employee.Fname,
        employee.Minit,
        employee.Lname,
        employee.Address,
        employee.Dno,
        employee.Ssn
    FROM employee
    INNER JOIN (
        SELECT Essn, proj.Plocation, proj.Pname
        FROM works_on
        INNER JOIN (
            SELECT Pnumber, Plocation, Pname
            FROM project
            WHERE Plocation='Aveiro')
        AS proj
        ON works_on.Pno=proj.Pnumber)
    AS wpr
    ON wpr.Essn=employee.Ssn)
AS wpre
ON wpre.Dno=dept_location.Dnumber
WHERE dept_location.Dlocation!='Aveiro'
````

<div style="page-break-after: always;"></div>

## Exercício 5.2
### a)
>π nif (fornecedor) - π encomenda.fornecedor (encomenda ⨝ (nif = fornecedor) fornecedor)

### b)
>γ produto.nome; avg(item.unidades) -> unidades
π item.numEnc, produto.codigo, produto.nome, item.unidades (produto ⨝ codProd = codigo item)

### c)
>γ avg(num_produtos) -> media_num_prod_por_encomenda
γ item.numEnc; count(produto.codigo) -> num_produtos
(item ⨝ codProd = codigo produto)

### d)
>π fornecedor.nif, fornecedor.nome, produto.codigo, produto.nome, item.unidades
(produto ⨝ item.codProd = codigo (fornecedor ⨝ encomenda.fornecedor = nif (item ⨝ numero = numEnc encomenda)))

## Exercício 5.3
### a)
>π paciente.numUtente, paciente.nome, paciente.dataNasc, paciente.endereco σ prescricao.numUtente = null paciente ⟕ paciente.numUtente = prescricao.numUtente prescricao
````SQL
SELECT paciente.*
FROM paciente
LEFT JOIN prescricao
ON paciente.numUtente=prescricao.numUtente
WHERE prescricao.numUtente IS NULL
````

### b)
>π medico.especialidade, Num γ especialidade; COUNT(numSNS)→Num medico ⨝ numMedico = numSNS prescricao
````SQL
SELECT medico.*, COUNT(numSNS) AS Num
FROM medico
INNER JOIN prescricao
ON numMedico=numSNS
GROUP BY especialidade
````

<div style="page-break-after: always;"></div>

### c)
>π prescricao.farmacia, Num γ farmacia; COUNT(farmacia)→Num σ farmacia ≠ null prescricao
````SQL
SELECT prescricao.*, COUNT(farmacia) AS Num
FROM prescricao
WHERE farmacia IS NOT NULL
GROUP BY farmacia
````

### d)
>farmaceutica ⟖ far.numRegFarm = farmaceutica.numReg ρ far π farmaco.numRegFarm, farmaco.nome, farmaco.formula σ farmaco.numRegFarm = 906 and presc_farmaco.numRegFarm = null farmaco ⟕ farmaco.numRegFarm = presc_farmaco.numRegFarm and farmaco.nome = presc_farmaco.nomeFarmaco presc_farmaco
````SQL
SELECT *
FROM farmaceutica
RIGHT JOIN (
    SELECT farmaco.*
    FROM farmaco
    LEFT JOIN presc_farmaco
    ON farmaco.numRegFarm=presc_farmaco.numRegFarm AND farmaco.nome=presc_farmaco.nomeFarmaco
    WHERE farmaco.numRegFarm=906 AND presc_farmaco.numRegFarm IS NULL)
AS far
ON far.numRegFarm=farmaceutica.numReg
````

### e)
>π prescricao.farmacia, presc_farmaco.numRegFarm, Num γ farmacia, numRegFarm; COUNT(numRegFarm)→Num σ farmacia ≠ null presc_farmaco ⨝ prescricao.numPresc = presc_farmaco.numPresc prescricao
````SQL
SELECT prescricao.*, presc_farmaco.numRegFarm , COUNT(numRegFarm) AS Num
FROM presc_farmaco
INNER JOIN prescricao
ON prescricao.numPresc=presc_farmaco.numPresc
WHERE farmacia IS NOT NULL
GROUP BY farmacia, numRegFarm
````

### d)