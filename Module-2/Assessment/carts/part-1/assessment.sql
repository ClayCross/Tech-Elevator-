USE assessment;
GO
  
-- Select all the columns in cart where the username is kmilner1j
Select * from carts where username = 'kmilner1j'
-- Select the id and name from cart_items where the item was added on or after Jan. 15, 2019 and the weight is null
Select id,name from cart_items where added > 2019-01-15 and weight = null;
-- Select username and the cookie_value from carts where the username isn't null, ordered by the created date, latest first
Select username, cookie_value from carts where username != null order by created desc 
-- Select the added date and the count of all the cart_items added on that date
Select added, count (added) from cart_items group by added
-- Select the cart's username and created date and the cart_item's name for all carts created in the month of Sept. 2019
