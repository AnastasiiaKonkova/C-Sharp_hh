/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class Program
{
    public static void Main(string[] args)
    {
        // Задаем время отправки рассылки (8:55 утра московского времени)
        var desiredTime = new TimeSpan(8, 55, 0);
        
        // Цикл будет выполняться каждый день
        while (true)
        {
            // Получаем текущее время
            var currentTime = DateTime.Now.TimeOfDay;
            
            // Если текущее время соответствует заданному времени отправки
            if (currentTime >= desiredTime)
            {
                try
                {
                    // Создаем экземпляр веб-драйвера
                    using (var driver = new ChromeDriver())
                    {
                        // Переходим на сайт hh.ru
                        driver.Navigate().GoToUrl("https://hh.ru");
                        
                        // Авторизуемся на сайте (замените на свои логин и пароль)
                        driver.FindElement(By.Id("email")).SendKeys("ваш_логин");
                        driver.FindElement(By.Id("password")).SendKeys("ваш_пароль");
                        driver.FindElement(By.CssSelector("input[data-qa='account-login-submit']")).Click();
                        
                        // Дожидаемся загрузки страницы с вакансиями
                        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.vacancy-serp-item")));
                        
                        // Выполняем поиск вакансий
                        var searchBox = driver.FindElement(By.CssSelector("input[data-qa='vacancy-serp__query']"));
                        searchBox.Clear();
                        searchBox.SendKeys("название вакансии");
                        driver.FindElement(By.CssSelector("button[data-qa='navi-search__button']")).Click();
                        
                        // Исключаем некоторые слова из поиска
                        var excludedWords = new List<string> { "слово1", "слово2", "слово3" };
                        foreach (var word in excludedWords)
                        {
                            driver.FindElement(By.CssSelector($"span.bloko-tag.m-selected span.bloko-icon_delete")).Click();
                            driver.FindElement(By.CssSelector("div.bloko-type-checkbox input.bloko-checkbox__input")).SendKeys(word + Keys.Enter);
                        }
                        
                        // Ожидаем загрузки результатов поиска
                        wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.vacancy-serp-item")));
                        
                        // Откликаемся на каждую вакансию
                        var vacancies = driver.FindElements(By.CssSelector("div.vacancy-serp-item"));
                        foreach (var vacancy in vacancies)
                        {
                            vacancy.FindElement(By.CssSelector("button[data-qa='vacancy-serp__vacancy-response-button']")).Click();
                            
                            // Дожидаемся открытия формы отклика
                            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("form.application-form")));
                            
                            // Заполняем форму отклика (например, имя, телефон, резюме)
                            driver.FindElement(By.CssSelector("input[data-qa='resume-respond-name']")).SendKeys("Ваше имя");
                            driver.FindElement(By.CssSelector("input[data-qa='resume-respond-phone']")).SendKeys("Ваш номер телефона");
                            driver.FindElement(By.CssSelector("textarea[data-qa='resume-respond-comment']")).SendKeys("Ваше резюме");
                            driver.FindElement(By.CssSelector("button[data-qa='resume-respond-send-button']")).Click();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
                
                // Ожидаем до конца текущего дня
                var remainingTime = DateTime.Today.AddDays(1).Add(desiredTime) - DateTime.Now;
                Thread.Sleep(remainingTime);
            }
            else
            {
                // Ожидаем до заданного времени отправки
                var timeUntilDesired = desiredTime - currentTime;
                Thread.Sleep(timeUntil);
                }}}}
*/
