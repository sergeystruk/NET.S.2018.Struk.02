–еализовать метод FindNextBiggerNumber, который принимает положительное целое число и возвращает ближайшее наибольшее целое, состо€щее из цифр исходного числа, и null (или -1), если такого числа не существует.
–азработать модульные тесты (NUnit или MS Unit Test) дл€ тестировани€ метода. ѕримерные тест-кейсы
[TestCase(12, ExpectedResult = 21)]
[TestCase(513, ExpectedResult = 531)]
[TestCase(2017, ExpectedResult = 2071)]
[TestCase(414, ExpectedResult = 441)]
[TestCase(144, ExpectedResult = 414)]
[TestCase(1234321, ExpectedResult = 1241233)]
[TestCase(1234126, ExpectedResult = 1234162)]
[TestCase(3456432, ExpectedResult = 3462345)]
[TestCase(10, ExpectedResult = -1)]
[TestCase(20, ExpectedResult = -1)]
ƒобавить к методу FindNextBiggerNumber возможность вернуть врем€ нахождени€ заданного числа, рассмотрев различные €зыковые возможности. –азработать модульные тесты (NUnit или MS Unit Test) дл€ тестировани€ метода.