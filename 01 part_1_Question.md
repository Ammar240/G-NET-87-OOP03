# Question 1
## Answer the following questions:
### a) What is the difference between a class and a struct?
- Struct -> Value semantics
- Class -> Reference semantics

### b) Why are classes more suitable than structs for large applications?
Because classes are reference types , while structs are value types 
large applications deals with objects that have identity ,shared state, inheritance and complex behavior
so reference semantic is better for complex objects

# Question 2
 
### a) Which class is the parent class? 
	Shipment class
### b) Which class is the child class?
	ExpressShipment
### c) What members are inherited by ExpressShipment? 
	TrackingCode property
### d) Why is inheritance better than duplicating the same code in multiple classes?
	inheritance promotes reusability, maintainability and extensibility