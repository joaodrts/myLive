﻿using myLive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLive.Repositories
{
    public interface iInstrutoresRepositorie
    {
        InstrutoresModel Adicionar(InstrutoresModel Instrutor);

        InstrutoresModel Alterar(InstrutoresModel Instrutor);

        bool Excluir(int ID);

        InstrutoresModel BuscarPorID(int ID);

        List<InstrutoresModel> BuscarTodos();

    }
}
