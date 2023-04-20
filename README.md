# Sales Management System

## Description

A Blazor WebAssembly app, for managing sales order data. 

## Task Details

1. Create new database tables Using Code First In Entity Framework.
2. Blazor WebAssembly app with an interface to show data from DB.
3. Make an ability to change and save data in the application: state, name, and dimensions.
4. Add the ability to create and delete orders, windows and elements.
5. Optional: Interface validations. DTO. Separated BLL and DAL projects.

## Tools and SDk

1. Visual Studio 2022
2. MS SQL Server 
3. .NET 7.0 SDK

## How to run the project

1. Clone the repository from GitHub ``git clone https://github.com/tanvirIqbal/sales-management-system.git``
2. Run the project in Visual Studio 2022
3. Go to ``Package Manager Console``
![PMC.PNG](Screenshot/PMC.png)  

4. Run this command in Package Manager Console.   
``Update-Database -Project SMS.DAL -StartupProject SMS.Server``

![PMC2.PNG](Screenshot/PMC2.PNG)  

If you see any error then check the connection string in ``appsettings.json`` file

![DBConn.PNG](Screenshot/DBConn.PNG)  

5. Run the project

![Run.PNG](Screenshot/Run.PNG)  

After Running the project

![1.Orders.PNG](Screenshot/1.Orders.PNG)  

6. Click ``Details`` to see the existing order details.

![2.1.DetailsClick.PNG](Screenshot/2.1.DetailsClick.PNG)  

You Can see the existing Order details

![2.2OrderDetails.PNG](Screenshot/2.2OrderDetails.PNG)  

7. Close the details and click the ``Add`` button to add a new order

![3.1.AddClick.PNG](Screenshot/3.1.AddClick.PNG)  

You can see the new order page

![3.2.NewOrder.PNG](Screenshot/3.2.NewOrder.PNG)  

8. Fill the Order Name and Order State then click the ``Add new Window`` button

![3.3.AddNewWindow.PNG](Screenshot/3.3.AddNewWindow.PNG)  

You can see the new window and sub element modal

![3.4.NewWindow.PNG](Screenshot/3.4.NewWindow.PNG)  

9. Fill up the window information and add sub element by clicking the ``Add Element`` button

![3.5.AddElement.PNG](Screenshot/3.5.AddElement.PNG)  

10. You can add the multiple sub element in this modal then click ``Add Window``.

![3.6.WindowAndElements.PNG](Screenshot/3.6.WindowAndElements.PNG)  

You can see the new window with sub element are added to the new order. You can add another window by clicking the ``Add Window`` button. 

11. Click ``Save``

![3.7.SaveOrder.PNG](Screenshot/3.7.SaveOrder.PNG)  

Your order is saved.

![3.8.OrderSaved.PNG](Screenshot/3.8.OrderSaved.PNG)  

12. Go to Orders page by page. You can see your newly added order.

![R3.9.NewOrderAddedun.PNG](Screenshot/3.9.NewOrderAdded.PNG)  

13. For editing a order, click the ``Edit`` button

![4.1.EditOrder.PNG](Screenshot/4.1.EditOrder.PNG)  

14. You can edit a order and it's window and sub element

![4.2.AddAndEditWindow.PNG](Screenshot/4.2.AddAndEditWindow.PNG)

![4.3.EditWindow.PNG](Screenshot/4.3.EditWindow.PNG)  

15. You can also delete a order.

![5.1.DeleteOrder.PNG](Screenshot/5.1.DeleteOrder.PNG)

![5.2.DeleteConfirm.PNG](Screenshot/5.2.DeleteConfirm.PNG)  

You can see that the order is deleted.

![5.3.OrderDeleted.PNG](Screenshot/5.3.OrderDeleted.PNG)

