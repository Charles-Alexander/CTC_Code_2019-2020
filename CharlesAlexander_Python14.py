# Charles Alexander Python project 1#
cuttinglabor1 = 1.2
cuttinglabor2 = 1.5
cuttinglabor3 = 1.9

sandinglabor1 = 2.4
sandinglabor2 = 1.8
sandinglabor3 = 1.2

finishinglabor1 = 3.4
finishinglabor2 = 2.5
finishinglabor3 = 1.5

upcabinet = float (input("How many upper cabinets?"))


lowcabinet = float (input("How many lower cabinets?"))

cornercabinet = float (input("How many corner cabinets?"))

total_cutting_hours = ((upcabinet * cuttinglabor1) + (lowcabinet * cuttinglabor2) + (cornercabinet * cuttinglabor3))
total_sanding_hours = ((upcabinet * sandinglabor1) + (lowcabinet * sandinglabor2) + (cornercabinet * sandinglabor3))
total_finishing_hours = ((upcabinet * finishinglabor1) + (lowcabinet * finishinglabor2) + (cornercabinet * finishinglabor3))
total_hours = total_cutting_hours + total_sanding_hours + total_finishing_hours

print ("Total Cutting hours: " + str(float(total_cutting_hours))) 
print ("Total Sanding hours: " + str(float(total_sanding_hours)))
print ("Total Finishing hours: " + str(float(total_finishing_hours)))
print ("Total hours: " + str(float(total_hours))) 