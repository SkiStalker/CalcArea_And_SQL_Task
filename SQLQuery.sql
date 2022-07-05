use main;
select main.dbo.product.name as product, 
coalesce (category.name,'') as category
from main.dbo.product 
left join main.dbo.products_categories 
on product_id = product.ID 
left join main.dbo.category 
on category.ID = category_id;
go