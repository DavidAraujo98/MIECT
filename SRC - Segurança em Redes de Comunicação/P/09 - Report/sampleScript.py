
# pip install pygeoip
# pip install fastparquet 
# pip install dnspython
import pandas as pd
import numpy as np
import ipaddress
import dns.resolver
import dns.reversename
import pygeoip
import matplotlib.pyplot as plt 

datafile='./dataset4/data4.parquet'

### IP geolocalization
gi=pygeoip.GeoIP('./GeoIP_DBs/GeoIP.dat')
gi2=pygeoip.GeoIP('./GeoIP_DBs/GeoIPASNum.dat')
addr='192.168.104.134'
cc=gi.country_code_by_addr(addr)
org=gi2.org_by_addr(addr)
print(cc,org)

### DNS resolution
addr=dns.resolver.resolve("www.ua.pt", 'A')
for a in addr:
    print(a)
    
### Reverse DNS resolution    
#name=dns.reversename.from_address("192.168.104.129")
#addr=dns.resolver.resolve(name, 'PT')
#for a in addr:
#    print(a)

### Read parquet data files
data=pd.read_parquet(datafile)
print(data['dst_ip'].apply(lambda ip: gi.country_code_by_addr(ip)))
#Just the UDP flows
udpF=data.loc[data['proto']=='udp']

#Number of UDP flows for each source IP
nudpF=data.loc[data['proto']=='udp'].groupby(['src_ip'])['up_bytes'].count()

#Number of UDP flows to port 443, for each source IP
nudpF443=data.loc[(data['proto']=='udp')&(data['port']==443)].groupby(['src_ip'])['up_bytes'].count()

#Average number of downloaded bytes, per flow, for each source IP
avgUp=data.groupby(['src_ip'])['down_bytes'].mean()
print(avgUp)
avgUp.drop_duplicates

#Total uploaded bytes to destination port 443, for each source IP, ordered from larger amount to lowest amount
upS=data.loc[((data['port']==443))].groupby(['src_ip'])['up_bytes'].sum().sort_values(ascending=False)

#Histogram of the total uploaded bytes to destination port 443, by source IP
upS=data.loc[((data['port']==443))].groupby(['src_ip'])['up_bytes'].sum().hist()
plt.show()

#Is destination IPv4 a public address?
NET=ipaddress.IPv4Network('192.168.100.0/24')
bpublic=data.apply(lambda x: ipaddress.IPv4Address(x['dst_ip']) not in NET,axis=1)

#Geolocalization of public destination adddress
cc=data[bpublic]['dst_ip'].apply(lambda y:gi.country_code_by_addr(y)).to_frame(name='cc')

