import unittest
from daily_katas_python import duplicate_count

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

if __name__ == '__main__':
    unittest.main()