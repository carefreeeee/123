# Задание:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

Юнит-тесты

Легкость добавления других фигур

Вычисление площади фигуры без знания типа фигуры в compile-time

Проверку на то, является ли треугольник прямоугольным


C# библиотека вычисления площади круга по радиусу и треугольника по трем сторонам




В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

select product.name [Имя продукта], category.name [Имя категории]

from Products product

left join ProductsCategory productcategory on product.id [ID продукта] = productcategory.products_id

inner join Categories category on categories.id [ID категории] = productcategory.categories_id

order by product.name
