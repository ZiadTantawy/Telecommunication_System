# Database-Integrated Web Application  
**Course:** Databases I - Winter 2024  
**Instructor:** Dr. Mervat Abuelkheir  
**Institution:** German University in Cairo - Media Engineering and Technology  

## Project Overview  
This project is a web application built as part of the Databases I course. It integrates a SQL Server database with a user-friendly interface to allow admins and customers to perform essential operations.  

The application consists of the following main components:  
- **Admin Portal:** Enables administrators to manage customer accounts, transactions, subscriptions, and vouchers.  
- **Customer Portal:** Provides customers access to their account details, consumption reports, benefits, and more.  

## Features  
### Admin Portal  
- **Part 1:**  
  1. Login with admin ID and password.  
  2. View customer profiles and their active accounts.  
  3. List physical stores and their redeemed vouchers.  
  4. View resolved technical support tickets.  
  5. View all customer accounts and their subscribed service plans.  
  6. List all accounts subscribed to a specific plan on a given date.  
  7. Display total usage of accounts on subscribed plans.  
  8. Remove all benefits for a specific account and plan.  
  9. List all SMS offers for an account.  

- **Part 2:**  
  1. View wallet details and associated customer names.  
  2. List E-shops and redeemed vouchers.  
  3. View transaction details and related accounts.  
  4. Count cashback transactions for each wallet.  
  5. Display accepted payment transactions and earned points for the last year.  
  6. Calculate cashback returned on a wallet for a specific plan.  
  7. Compute the average transaction amount within a specified period.  
  8. Check if a mobile number is linked to a wallet.  
  9. Update earned points for a given mobile number.  

### Customer Portal  
- **Part 1:**  
  1. Login with mobile number and password.  
  2. View details of offered service plans.  
  3. Check SMS, minutes, and internet usage for a specific plan and date range.  
  4. Display unsubscribed plans for a mobile number.  
  5. Show current month's usage for active plans.  
  6. View cashback transactions for the customer’s wallet.  

- **Part 2:**  
  1. View active benefits.  
  2. Check unresolved technical support tickets.  
  3. Display the highest-value voucher for an account.  
  4. Show remaining amount for the last payment for a plan.  
  5. Display extra amount from the last payment for a plan.  
  6. List top 10 successful payments by value.  

- **Part 3:**  
  1. View details of all shops.  
  2. Show service plans subscribed to in the past 5 months.  
  3. Renew subscriptions for a specific plan.  
  4. Compute cashback for a wallet from a specific transaction.  
  5. Recharge balance for a mobile number.  
  6. Redeem vouchers.  

## Milestones  
### **Milestone 1:**  
- Create an Entity-Relationship Diagram (ERD) for the database schema.  
- Implement the SQL Server database with all necessary tables and relations.  

### **Milestone 2:**  
- Write SQL scripts to perform CRUD operations and execute queries for project functionalities.  
- Populate the database with sample data.  

### **Milestone 3:**  
- Develop a web application that integrates the database functionalities with a user interface.  
- Implement both admin and customer components.  

## Technologies Used  
- **Frontend:** ASP.NET WebForms.  
- **Backend:** C# with ASP.NET Framework.  
- **Database:** Microsoft SQL Server.  
- **Tools:** Visual Studio, SQL Server Management Studio (SSMS).  
