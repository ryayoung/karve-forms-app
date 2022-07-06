## .NET Forms App for Karve Sample Database

*Created on 6-07-2021*

> Made in Visual Studio with VB. There are two follow-up projects for this one in separate repositories, linked below. This app is for the first version of the Karve OLTP database. The later versions were changed significantly.

- [**Part 2:** Simulation & Sample database](https://github.com/ryayoung/karve-sample-database)
- [**Part 3:** Data Warehouse](https://github.com/ryayoung/data-warehousing)

### Code

- [```OrderSearch.vb```:]() Custom search all customer orders and see customer details.
- [```Globals.vb```:]() Variables, functions and subs used globally, including the DIN calculator algorithm.
- [```DinCalculator.vb```]() & [```DinChart.vb```:]() A form for automatically calculate a binding DIN setting based on rider metrics.
- [```Startup.vb```:]() Side navigation bar
- [```Customers.vb```:]() The customer form, shown in read-only mode in the Search tab, or read & edit in its own window.
- [```SkiBinding.vb```]() & [```SkiModel.vb```:]() View inventory

- NOTE: There will be scaling issues with the forms if you have a 4k monitor, or if you're running VS on a display other than your primary display. If anything doesn't look right, see the screenshots below

![sc_Search](https://user-images.githubusercontent.com/90723578/177606457-66f6a8e3-2cb9-4b9f-8d2b-436f4b17528b.png)

![sc_DinCalculator](https://user-images.githubusercontent.com/90723578/177606476-8fe2e196-f24a-4368-86bf-334c8ef88793.png)

![sc_Customers](https://user-images.githubusercontent.com/90723578/177606496-f28c19f4-744e-41b1-9bbb-fea70f08fdd6.png)
