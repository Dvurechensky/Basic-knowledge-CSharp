using System;

/// <summary>
/// *описали характеристики обьекта, шаблона этого класса
/// *главный плюс - можем вынести класс в отдельный файл - чтобы не городить код в одну кучу
/// *если лежит в том же namespace то можем видеть его, если нет то нужно внести using
/// </summary>
class Students
{
    /// <summary>
    /// Cпециальная структура для описания объекта, создания уникальных id
    /// </summary>
    public Guid id;
    public string firstName;
    public string lastName;
    public string middleName;
    public int age;
    public string group;
}