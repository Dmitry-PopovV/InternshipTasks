USE Task2;
SELECT goods.name AS goodName, categories.name AS categoryName FROM goods 
LEFT JOIN goodsCategoriesLink ON goods.id = goodsCategoriesLink.good_id 
LEFT JOIN categories ON goodsCategoriesLink.category_id = categories.id;