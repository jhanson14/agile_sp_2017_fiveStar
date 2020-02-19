
CREATE PROCEDURE [dbo].[CustomerLogIn]   
 @username varchar(50),  
 @password varchar(50)  
AS  
BEGIN  
 SELECT Custid, Username, Password  
 FROM Login  
 WHERE Username = @Username  
 AND Password = @Password  
END