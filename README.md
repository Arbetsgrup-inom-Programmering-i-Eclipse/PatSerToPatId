# PatSerToPatId
Konvertera PatientSer till PatientID och kopiera det till clipboarden. 

Detta ska göras:

1. i "AriaInterface.cs" rad 8-10-12-14: ipaddress/servernamn till Aria databaserna. Alt. ta bort "AriaInterface.cs" från projektet och lägga till en "AriaInterface.cs" fil som redan har rätt info

2. (?) Kolla referenserna till VMS.TPS.Common.Model.API och VMS.TPS.Common.Model.Types är korrekta. Uppdatera dem annars
