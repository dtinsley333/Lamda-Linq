# Lamda Linq
Lamda Linq example with two orderby clauses


This is a simple console application running in .net core that demonstrates how to query a list of objects, filter them and order them. 

```
List<Customer> customers = highVolumeCustomers
                .Where(x => x.OrderCount > 100)
                .OrderByDescending(x => x.OrderCount)
                .ThenByDescending(x => x.Name)
                .ToList(); 
                
             
