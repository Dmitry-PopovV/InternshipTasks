USE Task2;

CREATE TABLE goods
   (
      id INT NOT NULL PRIMARY KEY,
      name VARCHAR(100) NOT NULL,
   );

INSERT INTO goods (id, name) VALUES (0, 'Молоко');
INSERT INTO goods (id, name) VALUES (1, 'Огурец');
INSERT INTO goods (id, name) VALUES (2, 'Яблоко');
INSERT INTO goods (id, name) VALUES (3, 'Стол');

CREATE TABLE categories
   (
      id INT NOT NULL PRIMARY KEY,
      name VARCHAR(100) NOT NULL,
   );

INSERT INTO categories (id, name) VALUES (0, 'Овощи');
INSERT INTO categories (id, name) VALUES (1, 'Продукты');
INSERT INTO categories (id, name) VALUES (2, 'Фрукты');

CREATE TABLE goodsCategoriesLink
   (
      good_id INT NOT NULL,
      category_id INT NOT NULL,
	  CONSTRAINT PK_goodsCategoriesLink PRIMARY KEY (good_id, category_id)
   );

INSERT INTO goodsCategoriesLink (good_id, category_id) VALUES (0, 1);
INSERT INTO goodsCategoriesLink (good_id, category_id) VALUES (1, 0);
INSERT INTO goodsCategoriesLink (good_id, category_id) VALUES (1, 1);
INSERT INTO goodsCategoriesLink (good_id, category_id) VALUES (2, 1);
INSERT INTO goodsCategoriesLink (good_id, category_id) VALUES (2, 2);

SELECT goods.name AS goodName, categories.name AS categoryName FROM goods 
LEFT JOIN goodsCategoriesLink ON goods.id = goodsCategoriesLink.good_id 
LEFT JOIN categories ON goodsCategoriesLink.category_id = categories.id;