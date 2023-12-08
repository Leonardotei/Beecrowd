SELECT
p.id, p.name
FROM categories c INNER JOIN products p ON
c.id = p.id_categories
WHERE c.name LIKE 'super%';
