import unittest
from RK2 import C, OS, C_OS, one_to_many_mapping,  many_to_many_mapping, task_a1, task_a2, task_a3

class TestComputerOSFunctions(unittest.TestCase):

    def setUp(self):
        self.Oski = [
            OS(1, 'Windows 10'),
            OS(2, 'Linux'),
            OS(3, 'macOS'),
            OS(11, 'Windows 11'),
            OS(22, 'Ubuntu'),
            OS(33, 'macOS Big Sur'),
        ]

        self.Comps = [
            C(1, 'Dell XPS 13', 16, 1),
            C(2, 'MacBook Air', 32, 3),
            C(3, 'Lenovo YOGA', 8, 2),
            C(4, 'HP Spectre', 16, 3),
            C(5, 'Asus TUF GAMING F15', 32, 2),
        ]

        self.comps_os = [
            C_OS(1, 1),
            C_OS(2, 2),
            C_OS(3, 3),
            C_OS(3, 4),
            C_OS(3, 5),
            C_OS(11, 1),
            C_OS(22, 2),
            C_OS(33, 3),
            C_OS(33, 4),
            C_OS(33, 5),
        ]

    def test_one_to_many_mapping(self):
        result = one_to_many_mapping(self.Comps, self.Oski)
        expected = [
            ('Dell XPS 13', 16, 'Windows 10'),
            ('MacBook Air', 32, 'macOS'),
            ('Lenovo YOGA', 8, 'Linux'),
            ('HP Spectre', 16, 'macOS'),
            ('Asus TUF GAMING F15', 32, 'Linux'),
        ]
        self.assertEqual(result, expected)

    def test_task_a2(self):
        one_to_many = one_to_many_mapping(self.Comps, self.Oski)
        result = task_a2(one_to_many, self.Oski)
        expected = [
            ('Linux', 40),
            ('macOS', 56),
            ('Windows 10', 16)
        ]
        self.assertEqual(result, expected)

    def test_task_a3(self):
        many_to_many = many_to_many_mapping(self.Comps, self.Oski, self.comps_os)
        result = task_a3(many_to_many, self.Oski)
        expected = {
            'Windows 10': ['Dell XPS 13'],
            'macOS': ['MacBook Air', 'HP Spectre'],
            'macOS Big Sur': ['Asus TUF GAMING F15']
        }
        self.assertEqual(result, expected)

if __name__ == '__main__':
    unittest.main()
