from operator import itemgetter
from typing import List, Tuple


class C:
    def __init__(self, id: int, model: str, ram: int, os_id: int):
        self.id = id
        self.model = model
        self.ram = ram
        self.os_id = os_id


class OS:
    def __init__(self, id: int, name: str):
        self.id = id
        self.name = name


class C_OS:
    def __init__(self, os_id: int, comp_id: int):
        self.os_id = os_id
        self.comp_id = comp_id


def one_to_many_mapping(comps: List[C], oski: List[OS]) -> List[Tuple[str, int, str]]:
    return [(c.model, c.ram, o.name)
            for o in oski
            for c in comps
            if c.os_id == o.id]


def many_to_many_mapping(comps: List[C], oski: List[OS], comps_os: List[C_OS]) -> List[Tuple[str, int, str]]:
    many_to_many_temp = [(o.name, co.os_id, co.comp_id)
                         for o in oski
                         for co in comps_os
                         if o.id == co.os_id]
    return [(c.model, c.ram, os_name)
            for os_name, os_id, comp_id in many_to_many_temp
            for c in comps if c.id == comp_id]


def task_a1(one_to_many: List[Tuple[str, int, str]]) -> List[Tuple[str, int, str]]:
    return sorted(one_to_many, key=itemgetter(2))


def task_a2(one_to_many: List[Tuple[str, int, str]], oski: List[OS]) -> List[Tuple[str, int]]:
    res_12_unsorted = []
    for o in oski:
        o_comps = list(filter(lambda i: i[2] == o.name, one_to_many))
        if len(o_comps) > 0:
            o_rams = [ram for _, ram, _ in o_comps]
            o_rams_sum = sum(o_rams)
            res_12_unsorted.append((o.name, o_rams_sum))
    return sorted(res_12_unsorted, key=itemgetter(1), reverse=False)


def task_a3(many_to_many: List[Tuple[str, int, str]], oski: List[OS]) -> dict:
    res_13 = {}
    for o in oski:
        if 'Windows' in o.name or 'macOS' in o.name:
            o_comps = list(filter(lambda i: i[2] == o.name, many_to_many))
            o_comps_models = [x for x, _, _ in o_comps]
            res_13[o.name] = o_comps_models
    return res_13
