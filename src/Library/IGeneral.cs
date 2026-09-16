using System;
using System.Collections.Generic;

namespace Ucu.Poo.Repositories
{
    /// <summary>
    /// Esta interfaz representa un objeto que puede ser comparado con otro
    /// objeto del mismo tipo.
    /// </summary>
    /// <typeparam name="T">El tipo de objeto a comparar.</typeparam>
    public interface IDataBase<T>
    {
        /// <summary>
        /// Agrega un elemento a la base de datos.
        /// </summary>
        /// <param name="item">El elemento a agregar.</param>
        void Add(T item);

        /// <summary>
        /// Elimina un elemento de la base de datos.
        /// </summary>
        /// <param name="item">El elemento a eliminar.</param>
        void Remove(T item);

        /// <summary>
        /// Busca un elemento en la base de datos que cumpla con un criterio
        /// específico.
        /// </summary>
        /// <param name="criteria">El criterio por el cual buscar.</param>
        /// <returns>El elemento encontrado que cumple el criterio especificado o
        /// null si no se encuentra ninguno.</returns>
        T Find(Predicate<T> criteria);
    }
}