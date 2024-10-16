using BenchmarkDotNet.Attributes;

namespace ComparingDataTypesPerformance.Abstract;

/// <summary>
/// Базовый функционал сравнения производительности типов
/// </summary>
/// <typeparam name="TCollectionType">Тип коллекции</typeparam>
/// <typeparam name="TType">Тип содержимого коллекции</typeparam>
public abstract class AbstractComparer<TCollectionType, TType>
    where TCollectionType : IEnumerable<TType>
{
    /// <summary>
    /// Сравнение производительности добавления элементы к типу данных.
    /// </summary>
    /// <param name="collection">Коллекция к которой будет добавляться новый объект</param>
    /// <param name="addedItem">Добавляемый объект</param>
    [Benchmark]
    public abstract void Add();
}
