SELECT products.name, ISNULL(categories.category_name, 'No category') as category_name
FROM products
LEFT JOIN product_categories
ON products.id = product_categories.product_id
LEFT JOIN categories
ON product_categories.category_id = categories.id;
