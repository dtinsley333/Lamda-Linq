# Lamda Linq
Lamda Linq example with two orderby clauses

```
List<Customer> customers = highVolumeCustomers
                .Where(x => x.OrderCount > 100)
                .OrderByDescending(x => x.OrderCount)
                .ThenByDescending(x => x.Name)
                .ToList(); 
                
             
