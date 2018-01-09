﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCottonFix
{
    interface ICrudBase <T>
    {
        bool Salvar(bool Insert, T objeto);
        bool Excluir(T objeto);
        T Pesquisar(int codigo);
    }
}