import unittest
from daily_katas_python import duplicate_count
from daily_katas_python import even_or_odd
from daily_katas_python import median

class Duplicate_count_1(unittest.TestCase):
    def test_A(self):
        self.assertEqual(duplicate_count(""), 0)
        
class Duplicate_count_2(unittest.TestCase):
    def test_A(self):
        self.assertEqual(duplicate_count("abcde"), 0)

class Duplicate_count_3(unittest.TestCase):
    def test_A(self):
        self.assertEqual(duplicate_count("abcdeaa"), 1)

class Duplicate_count_4(unittest.TestCase):
    def test_A(self):
        self.assertEqual(duplicate_count("abcdeaB"), 2)
        
class Duplicate_count_5(unittest.TestCase):
    def test_A(self):
        self.assertEqual(duplicate_count("Indivisibilities"), 2)

class Even_or_odd_1(unittest.TestCase):
    def test_A(self):
        self.assertEqual(even_or_odd(2), "Even")
    def test_B(self):
        self.assertEqual(even_or_odd(1), "Odd")
    def test_C(self):
        self.assertEqual(even_or_odd(0), "Even")
    def test_D(self):
        self.assertEqual(even_or_odd(1545452), "Even")
    def test_E(self):
        self.assertEqual(even_or_odd(7), "Odd")
    def test_F(self):
        self.assertEqual(even_or_odd(78), "Even")
    def test_G(self):
        self.assertEqual(even_or_odd(17), "Odd")
    def test_H(self):
        self.assertEqual(even_or_odd(74156741), "Odd")
    def test_I(self):
        self.assertEqual(even_or_odd(100000), "Even")
    def test_J(self):
        self.assertEqual(even_or_odd(-123), "Odd")
    def test_K(self):
        self.assertEqual(even_or_odd(-456), "Even")

class Find_median(unittest.TestCase):
    def test_A(self):
        self.assertEqual(median([3,2,1]),2)
    def test_B(self):
        self.assertEqual(median([1]),1)
    def test_C(self):
        self.assertEqual(median([1234,345,78]),345)
    def test_D(self):
        self.assertEqual(median([33,99,100,30,29,50]), 41.5)
    def test_E(self):
        self.assertEqual(median([3,50]), 26.5)

if __name__ == '__main__':
    unittest.main()