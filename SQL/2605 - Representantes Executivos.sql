SELECT 
p.name,
r.name
FROM products p INNER JOIN providers r ON
p.id_providers = r.id
WHERE p.id_categories = 6;
