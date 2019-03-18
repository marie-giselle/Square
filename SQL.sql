SELECT
	Products.Name,
	Categories.Name
FROM ProductCategories --Соединительная таблица, хранящая связи продуктов с категориями
	JOIN Categories
		ON ProductCategories.CategoryId = Categories.Id
	RIGHT JOIN Products
		ON ProductCategories.ProductId = Products.Id