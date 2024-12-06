--Chatgpt Test Data

--TODO : Try dropAllProceduresFunctionsViews

--Customer Profile
INSERT INTO customer_profile (nationalID, first_name, last_name, email, address, date_of_birth)
VALUES 
(1, 'John', 'Doe', 'john.doe@example.com', '123 Main St', '1990-05-15'),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '456 Elm St', '1985-10-22'),
(3, 'Alice', 'Johnson', 'alice.johnson@example.com', '789 Oak St', '1992-07-18'),
(4, 'Bob', 'Brown', 'bob.brown@example.com', '101 Pine St', '1988-11-11'),
(5, 'Carol', 'Davis', 'carol.davis@example.com', '202 Maple St', '1995-03-04');




--Customer Account
INSERT INTO customer_account (mobileNo, pass, balance, account_type, start_date, status, points, nationalID)
VALUES 
('12345678901', 'pass123', 50.0, 'Prepaid', '2022-01-01', 'active', 1000, 1),
('23456789012', 'pass234', 75.5, 'Post Paid', '2021-06-15', 'active', 2000, 2),
('34567890123', 'pass345', 30.0, 'Pay_as_you_go', '2023-03-10', 'onhold', 0, 3),
('45678901234', 'pass456', 120.0, 'Prepaid', '2022-12-01', 'active', 500, 4),
('56789012345', 'pass567', 15.0, 'Post Paid', '2021-09-20', 'onhold', 250, 5);

--Service Plan
INSERT INTO Service_plan (SMS_offered, minutes_offered, data_offered, name, price, description)
VALUES 
(100, 500, 5, 'Basic Plan', 20, 'Affordable basic plan'),
(200, 1000, 10, 'Standard Plan', 50, 'Popular mid-tier plan'),
(500, 2000, 50, 'Premium Plan', 100, 'Comprehensive high-tier plan'),
(300, 1500, 30, 'Family Plan', 80, 'Ideal for families'),
(1000, 5000, 100, 'Business Plan', 200, 'Designed for businesses');



--Subscription
INSERT INTO Subscription (mobileNo, planID, subscription_date, status)
VALUES 
('12345678901', 1, '2023-01-01', 'active'),
('23456789012', 2, '2023-02-15', 'onhold'),
('34567890123', 3, '2023-03-20', 'active'),
('45678901234', 4, '2023-04-10', 'active'),
('56789012345', 5, '2023-05-05', 'onhold');

select * from Subscription
INSERT INTO Subscription (mobileNo, planID, subscription_date, status)
VALUES 
('12345678901', 3, '2024-07-07', 'active')

--Plan Usage
INSERT INTO Plan_Usage (start_date, end_date, data_consumption, minutes_used, SMS_sent, mobileNo, planID)
VALUES 
('2023-01-01', '2023-01-31', 2, 300, 50, '12345678901', 1),
('2023-02-01', '2023-02-28', 5, 800, 120, '23456789012', 2),
('2023-03-01', '2023-03-31', 10, 1000, 200, '34567890123', 3),
('2023-04-01', '2023-04-30', 8, 1200, 150, '45678901234', 4),
('2023-05-01', '2023-05-31', 20, 3000, 500, '56789012345', 5);



--Payment
INSERT INTO Payment (amount, date_of_payment, payment_method, status, mobileNo)
VALUES 
(25.0, '2023-06-01', 'cash', 'successful', '12345678901'),
(50.0, '2023-06-02', 'credit', 'successful', '23456789012'),
(10.0, '2023-06-03', 'cash', 'pending', '34567890123'),
(100.0, '2023-06-04', 'credit', 'rejected', '45678901234'),
(200.0, '2023-06-05', 'cash', 'successful', '56789012345');



--Wallet 
INSERT INTO Wallet (current_balance, currency, last_modified_date, nationalID, mobileNo)
VALUES 
(50.00, 'USD', '2023-06-01', 1, '12345678901'),
(75.00, 'USD', '2023-06-02', 2, '23456789012'),
(30.00, 'USD', '2023-06-03', 3, '34567890123'),
(120.00, 'USD', '2023-06-04', 4, '45678901234'),
(15.00, 'USD', '2023-06-05', 5, '56789012345');



--Transfer Money
INSERT INTO transfer_money (walletID1, walletID2, amount, transfer_date)
VALUES
(1, 2, 15.00, '2023-06-10'),
(2, 3, 10.00, '2023-06-12'),
(3, 4, 20.00, '2023-06-14'),
(4, 5, 25.00, '2023-06-16'),
(5, 1, 5.00, '2023-06-18');


--Benefits
INSERT INTO Benefits (description, validity_date, status, mobileNo)
VALUES
('Free 50 SMS', '2023-12-31', 'active', '12345678901'),
('500 MB Extra Data', '2023-11-30', 'expired', '23456789012'),
('100 Minutes', '2023-10-31', 'active', '34567890123'),
('Cashback 10%', '2023-09-30', 'expired', '45678901234'),
('Double Points', '2023-08-31', 'active', '56789012345');


--Points Group
INSERT INTO Points_group (benefitID, pointsAmount, PaymentID)
VALUES
(1, 10, 1),
(2, 20, 2),
(3, 15, 3),
(4, 25, 4),
(5, 30, 5);


--Exclusive Offer
INSERT INTO Exclusive_offer (benefitID, internet_offered, SMS_offered, minutes_offered)
VALUES
(1, 500, 50, 0),
(2, 1000, 0, 100),
(3, 200, 0, 50),
(4, 300, 50, 50),
(5, 0, 100, 200);


--Cashback
INSERT INTO Cashback (benefitID, walletID, amount, credit_date)
VALUES
(1, 1, 2, '2023-06-15'),
(2, 2, 5, '2023-06-16'),
(3, 3, 3, '2023-06-17'),
(4, 4, 10, '2023-06-18'),
(5, 5, 15, '2023-06-19');


--Plan Provides Benefits
INSERT INTO plan_provides_benefits (benefitID, planID)
VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);


--Shop
INSERT INTO shop (name, category)
VALUES
('Tech World', 'Electronics'),
('Grocery Galore', 'Food'),
('Fashion Forward', 'Clothing'),
('Book Haven', 'Books'),
('Home Comforts', 'Furniture');

--Physical Shop
INSERT INTO Physical_shop (shopID, address, working_hours)
VALUES
(1, '123 Mall St', '9 AM - 9 PM'),
(2, '456 Market Ln', '8 AM - 8 PM'),
(3, '789 Fashion Ave', '10 AM - 10 PM'),
(4, '101 Book Blvd', '9 AM - 5 PM'),
(5, '202 Furniture Rd', '11 AM - 7 PM');



--E-shop
INSERT INTO E_shop (shopID,URL, rating)
VALUES
(1, 'www.techworld.com', 5),
(2, 'www.grocerygalore.com', 4),
(3, 'www.fashionforward.com', 3),
(4, 'www.bookhaven.com', 5),
(5, 'www.homecomforts.com', 4);


--Voucher
INSERT INTO Voucher (value, expiry_date, points, mobileNo, shopID, redeem_date)
VALUES
(10, '2023-12-31', 100, '12345678901', 1,null),
(20, '2023-11-30', 200, '23456789012', 2,null),
(15, '2023-10-31', 150, '34567890123', 3,null),
(25, '2023-09-30', 250, '45678901234', 4,null),
(30, '2023-08-31', 300, '56789012345', 5,null);


--Technical Support Ticket
INSERT INTO Technical_support_ticket (mobileNo, Issue_description, priority_level, status)
VALUES
('12345678901', 'Unable to access account', 1, 'Open'),
('23456789012', 'Payment not processed', 2, 'In Progress'),
('34567890123', 'Slow internet', 1, 'Resolved'),
('45678901234', 'Plan benefits not updated', 3, 'Open'),
('56789012345', 'Incorrect balance', 2, 'Resolved');


--2.1)
-- b) -- Approved
exec createAllTables

--c) Approved
exec dropAllTables 

--d) Approved
exec dropAllProceduresFunctionsViews

--e) Approved
exec clearAllTables



--2.2)
--a) Approved 
select * from allCustomerAccounts

--b) Approved
select * from allServicePlans

--c) Approved
select * from allBenefits

--d) Approved
select * from AccountPayments

--e) Approved
select * from allShops

--f) Approved
select * from allResolvedTickets

--g) Approved
select * from CustomerWallet

--h) Approved
select * from E_shopVouchers

--i) Approved
select * from PhysicalStoreVouchers

--j) Approved
select * from Num_of_cashback



--2.3)
--a) Approved
exec Account_Plan

--b) Approved
select * from Account_Plan_date('2023-01-01',1)

--c) Approved
select * from Account_Usage_Plan('12345678901','2023-01-28')

--d) Approved
EXEC Benefits_Account @MobileNo = '12345678901', @plan_ID = 1;


--e) Approved
select * from Account_SMS_Offers('56789012345')

--f) Approved
exec Account_Payment_Points @MobileNo = '12345678901'

--g) Approved (Not sure)?
select dbo.Wallet_Cashback_Amount(2,2)


--h) 
select dbo.Wallet_Transfer_Amount(1,'2023-01-01','2023-12-12')

--i) Approved
select dbo.Wallet_MobileNo('45678901234')

--j) Approved
declare @total_points int
exec Total_Points_Account @MobileNo = '23456789012', @Total_points = @total_points OUTPUT
select @Total_points


--2.4)
--a) Approved
select dbo.AccountLoginValidation('12345678901','pass123')

--b)  Approved
select * from  dbo.Consumption('Basic Plan','2023-01-01','2023-02-02')


--c)
exec Unsubscribed_Plans @MobileNo = '56789012345'
select * from Service_Plan
select * from Subscription

--m)
EXEC Payment_wallet_cashback @MobileNo = '23456789012', @payment_id = 2, @benefit_id = 2;
SELECT * FROM Cashback
SELECT * FROM Wallet
SELECT * FROM Benefits
SELECT * FROM Payment
--n) Approved
EXEC Initiate_balance_payment @MobileNo = '12345678901', @amount = 50.0, @payment_method = 'credit';
SELECT * FROM Customer_Account WHERE mobileNo = '12345678901';
SELECT * FROM Payment WHERE mobileNo = '12345678901';



--o)
exec Redeem_voucher_points @MobileNo='12345678901',@voucher_id=1
SELECT * FROM Customer_Account
SELECT * FROM Voucher

SELECT dbo.Extra_plan_amount('12345678901', 'Basic Plan') AS ExtraAmount

--___________________________________________________________________________________________
select * from Customer_profile
select * from Customer_Account
select * from Service_Plan
select * from Subscription
select * from Plan_Usage
select * from Payment
select * from Process_Payment
select * from Wallet
select * from Transfer_money
select * from Benefits
select * from Points_Group
select * from Exclusive_Offer
select * from Cashback
select * from Plan_Provides_Benefits
select * from Shop
select * from Physical_Shop
select * from E_Shop
select * from Voucher
select * from Techincal_Support_Ticket





