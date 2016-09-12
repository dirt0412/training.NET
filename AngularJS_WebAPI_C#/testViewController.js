(function () {//IIFE encapsulation
    'use strict';//checked 'correct' code in browser

    var moduleId = 'user';//name of module in angularjs
    var controllerId = 'testViewController2';//name of controller

    angular.module(moduleId).controller(controllerId, TestViewController);

    TestViewController.$inject = ['$scope', '$http', '$location'];//array of objects 

    function TestViewController($scope, $http, $location) {
        //-----variables
        var vm = this;//assign the controller to the variable vm
        vm.text = "test bind";//any variable
        vm.searchByMail = "";
        vm.listOfPersons = [];
        vm.isAnyPersons = false;
        vm.person = {};//empty object
        var emptyPerson = {};//empty local object
        //vm.person.name="";
        //vm.person.adress="";
        //vm.person.age="";
        //vm.person.mail = "";
        vm.deleteByMail = "";
        //--------------

        //-----events
        vm.onOK = onOK;
        vm.getOne = getOne;//vm.getOne - function global
        vm.getOneNew = getOneNew;//vm.getOneNew - function global
        vm.getAllPerson = getAllPerson;//vm.getAllPerson - function global
        vm.getPersonsByMail2 = getPersonsByMail1;//vm.getPersonsByMail2 - function global , getPersonsByMail1 - function local
        vm.addNewPerson = addNewPerson1;//vm.addNewPerson 
        vm.deletePerson = deletePerson2;//vm.deletePerson 
        vm.updatePerson2 = updatePerson3;//vm.updatePerson2 
        //-----------

        function onOK(val) {
            console.log(val);
        }

        function getOne()//function local
        {
            $http({
                method: 'GET',
                url: $location.protocol() + '://' + $location.host() + ($location.port() == '80' ? '' : ':' + $location.port()) + '/api/TestView/Get2',
                headers: { 'Content-Type': 'application/json' },
                data: {
                   
                }
            })
                .success(function (data, status, headers, config) {
                    console.log('method Get2 = ' + data);
                })
                .error(function (data, status, headers, config) {
                    
                });
        }
        function getOneNew()
        {
            $http({
                method: 'GET',
                url: $location.protocol() + '://' + $location.host() + ($location.port() == '80' ? '' : ':' + $location.port()) + '/api/TestView/',
                headers: { 'Content-Type': 'application/json' },
                data: {

                }
            })
                .success(function (data, status, headers, config) {
                    console.log('method Get2New = ' + data);
                })
                .error(function (data, status, headers, config) {

                });
        }

        function getAllPerson()
        {
            $http({
                method: 'GET',
                url: $location.protocol() + '://' + $location.host() + ($location.port() == '80' ? '' : ':' + $location.port()) + '/api/TestView/getAllPersons',
                headers: { 'Content-Type': 'application/json' },
                data: {

                }
            })
                .success(function (data, status, headers, config) {
                    if (data.items.length > 0) {
                        vm.isAnyPersons = true;
                        var i;
                        console.log('method getAllPerson: ');
                        for (i = 0; i < data.items.length; i++) {
                            console.log('Mail:' + data.items[i].mail + ' Name:' + data.items[i].name + ' Adress:' + data.items[i].adress + ' Age:' + data.items[i].age);
                        }
                        vm.listOfPersons = data.items;
                        emptyPerson = data.emptyPerson;
                        vm.person = angular.copy(emptyPerson);
                        //console.log(vm.listOfPersons);
                    }
                })
                .error(function (data, status, headers, config) {

                });
        }

        function getPersonsByMail1(mail)
        {
            vm.searchByMail = mail;
            getPersonsByMail();
        }
        function getPersonsByMail()
        {
            $http({
                method: 'GET',
                url: $location.protocol() + '://' + $location.host() + ($location.port() == '80' ? '' : ':' + $location.port()) + '/api/TestView/getPersonsByMail',
                headers: { 'Content-Type': 'application/json' },
                params: { mail: vm.searchByMail },
                data: {

                }
            })
                .success(function (data, status, headers, config) {
                   console.log('method getPersonsByMail: Mail:' + data.mail + ' Name:' + data.name + ' Adress:' + data.adress + ' Age:' + data.age);
                })
                .error(function (data, status, headers, config) {

                });
        }

        function addNewPerson1() {
            //vm.person.name = 'Name6';
            //vm.person.adress = 'Adress 44';
            //vm.person.age = '55';
            //vm.person.mail = 'mail376@m.com';
            addNewPerson();
        }
        function addNewPerson() {
            
            $http({
                method: 'POST',
                url: $location.protocol() + '://' + $location.host() + ($location.port() == '80' ? '' : ':' + $location.port()) + '/api/TestView/addNewPerson1',
                headers: { 'Content-Type': 'application/json' },
                //params: { name: vm.person.name, adress: vm.person.adress, mail: vm.person.mail, age: vm.person.age, hobby:vm.person.hobby },
                data: vm.person
            })
                .success(function (data, status, headers, config) {
                    getAllPerson();
                    ClearFieldsPerson();
                    //if (data.length > 0) {
                    //    console.log('method getPersonsByMail: Mail:' + data[0].mail + 'Name' + data[0].name + 'Adress:' + data[0].addres + 'Age' + data[0].age);

                    //}
                })
                .error(function (data, status, headers, config) {

                });
        }

        function deletePerson2() {
            $http({
                method: 'DELETE',
                url: $location.protocol() + '://' + $location.host() + ($location.port() == '80' ? '' : ':' + $location.port()) + '/api/TestView/deletePerson1',
                headers: { 'Content-Type': 'application/json' },
                params: { mail: vm.deleteByMail }
                //data: vm.person
            })
                .success(function (data, status, headers, config) {
                    getAllPerson();
                    vm.deleteByMail = "";
                    //ClearFieldsPerson();
                    //if (data.length > 0) {
                    //    console.log('method getPersonsByMail: Mail:' + data[0].mail + 'Name' + data[0].name + 'Adress:' + data[0].addres + 'Age' + data[0].age);

                    //}
                })
                .error(function (data, status, headers, config) {

                });
        }

        function updatePerson3()
        {
            $http({
                method: 'PUT',
                url: $location.protocol() + '://' + $location.host() + ($location.port() == '80' ? '' : ':' + $location.port()) + '/api/TestView/updatePerson1',
                headers: { 'Content-Type': 'application/json' },
                data:  vm.person
            })
                .success(function (data, status, headers, config) {
                    getAllPerson();
                    ClearFieldsPerson();
                })
                .error(function (data, status, headers, config) {

                });
        }

        function ClearFieldsPerson() {
            vm.person = angular.copy(emptyPerson);            
            //vm.person.name = '';
            //vm.person.adress = '';
            //vm.person.age = '';
            //vm.person.mail = '';
        }

        function initialize()
        {
            getAllPerson();
        }
        initialize();
    }

})();