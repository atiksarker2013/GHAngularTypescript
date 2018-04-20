﻿module App {
    export class StudentService {

        http: angular.IHttpService;
        q: angular.IQService;
        students: Student[];

        static $inject = ["$http", "$q"];
        constructor(http: angular.IHttpService, q: angular.IQService) {
            this.students = [];
            this.http = http;
            this.q = q;
        }

        get(): angular.IPromise<any> {

            var self = this;
            var deffered = self.q.defer();

            var f1 = function (successresponse) {
                console.log(successresponse);
                deffered.resolve(successresponse);
            };

            var f2 = function (errorResponse) {
                console.log(errorResponse);
                deffered.reject(errorResponse);
            };

            self.http.get("http://localhost:51420/api/Students").then(f1, f2);
            return deffered.promise;

        }

        save(student: Student): angular.IPromise<any> {
            var self = this;
            var deffered = self.q.defer();

            var f1 = function (successresponse) {
                console.log(successresponse);
                deffered.resolve(successresponse);
            };

            var f2 = function (errorResponse) {
                console.log(errorResponse);
                deffered.reject(errorResponse);
            };


            self.http.post("http://localhost:51420/api/Students", student).then(f1, f2);
            return deffered.promise;
        }

        search(request: StudentRequestModel): angular.IPromise<any> {
            var self = this;
            var deffered = self.q.defer();

            var f1 = function (successresponse) {
                console.log(successresponse);
                deffered.resolve(successresponse);
            };

            var f2 = function (errorResponse) {
                console.log(errorResponse);
                deffered.reject(errorResponse);
            };

            self.http.post("http://localhost:51420/api/StudentQuery", request).then(f1, f2);
            return deffered.promise;
        }

    }

    angular.module('app').service("StudentService", StudentService);
}