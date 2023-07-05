﻿using System;
using System.Collections.Generic;
using Configuration.Domain.Model.TipoProyecto;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Factories
{
    public interface ITipoProyectoFactory
    {
        TipoProyecto CrearTipoProyecto(string nombre, string descripcion);

        TipoProyecto CrearTipoProyecto();
    }
}