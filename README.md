# PSD Project : CentuDY

**CentuDY** is a newly established medicine shop in Bluejack Land. To start its business, it needs to create a website for their shop. In that website, people can find information about the medicines which CentuDY sells and buy it. This website also allows admin to manage its users, medicines and all transactions made by users.

As a web developer, you are asked to create a website using **ASP.NET** for this online shop. You are also **required** to use **Domain Driven Design** method to develop the website. Please note that using web service is **optional** in this project. The **required** layers are:

- **View**

  View layer, or Presentation Layer, is responsible for showing information to the user and interpreting the user's commands. This layer is the home for all user interfaces in the project.

- **Controller**

  This layer is responsible to **validate** all input from the view layer. It also responsible for **delegating request**s from the user to the lower layer for further processing.

- **Handler**

  This layer is responsible to handle all **business logic** required in the application. It will delegates the task to query from the database, including select, insert, update and delete, to the repository layer. Please notes that there can be a single handler that accesses multiple repository. 

- **Repository**

  Repository layer responsible for **giving access** to the database and model layer via its public interfaces to acquiring references to preexisting domain objects. It provides methods to manipulate the object, such as add and delete, which will **encapsulate the actual manipulation operation** of data in the data store (or database). Repository also provides methods that select objects based on some criteria and return fully **instantiated** objects or collection of objects whose attribute meets those criteria.

- **Factory**

  You need to encapsulate all **complex object creation** in this layer. For example, when the client needs to create an aggregate object (an object that holds a reference to another object), the object factory must provide an interface for creating these objects. It is important to notes that an object returned by the factory must in **a consistent** state.

- **Model**

  The model layer is responsible for **representing concepts** in the business or information about the business situation.


### The ERD of CentuDY Database

![ERD CentuDY](erd-centudy.png) (TBA)

### User Roles

- **Administrator**
- **Member**
- **Guest** (**non-logged-in user**)
