angular.module("extentComponent")
.directive("inputFreq", ['freqRes','$timeout', function (freqRes,$timeout) {
    return {
        resctict: "E",
        templateUrl: "/AppScripts/components/inputFreq/inputFreq.html",
        scope: {
            value: "@value",
            callbackFn: "&callback",
            required: "@required",
            searchwords:"@"
        },
        link: function (scope, element, attrs) {
            scope.rowNo= -1;
            scope.len= 0;
            scope.focus = function () {
                return scope.showList = !!scope.len;
            }

            scope.blur = function () {
                $timeout(function () {
                    scope.showList = false;
                },100)
            }

            scope.keydown = function (event) {
                /*var e = event || window.event;
                var keyCode = e.keyCode || e.which;
                if (keyCode == 9 || keyCode == 13) {
                    return false;
                }*/
            }

            scope.change = function () {
                scope.showList = false;
                scope.len = 0;
                if (!scope.searchWords || $.trim(scope.searchWords) == "") return;
                freqRes.get({ keyWord: scope.searchWords, currentPage: 1, pageSize: 10 }, function (data) {
                    scope.items = data.Data;
                    scope.len = data.Data.length;
                    if (scope.len) {
                        scope.showList = true;
                    }
                });
            }


            scope.rowClick = function (item) {
                scope.callbackFn({ item: item });//回调函数
                scope.searchWords = item.FREQNO;
                scope.showList = false;//隐藏列表
            };
            //根据关键字过滤结果
            scope.filterItems = function (item) {
                return ((angular.isDefined(item.FREQNO) && item.FREQNO.toUpperCase().indexOf(scope.searchWords.toUpperCase()) >= 0) ||
                        (angular.isDefined(item.FREQNAME) && item.FREQNAME.toUpperCase().indexOf(scope.searchWords.toUpperCase()) >= 0) ||
                        !angular.isDefined(scope.searchWords)
                );
            };
//按键盘

            element.on('keyup', function (event) {
                var tElement = element.find('table tbody tr'), indis = 1, len = tElement.length;
                var e = event || window.event;
                var keyCode = e.keyCode || e.which;

                for (var k = 0; k < len; k++) {
                    tElement[k].style.backgroundColor = "lightgray";
                }
                //Up事件的标识代码
                if (keyCode == 38) {
                    e.preventDefault ? e.preventDefault() : e.returnValue = false;
                    scope.rowNo--;
                    if (scope.rowNo < 0) {
                        scope.rowNo = len - 1;
                    }

                } else if (keyCode == 40) {
                    e.preventDefault ? e.preventDefault() : e.returnValue = false;
                    scope.rowNo++;
                    if (scope.rowNo > len - 1) {
                        scope.rowNo = 0;
                    }

                }
                if (tElement[scope.rowNo]) {
                    tElement[scope.rowNo].style.backgroundColor = "#FFFFFF";
                }
                //Enter事件的标识代码
                if (keyCode == 13) {
                    for (var k = 0; k < len; k++) {
                        if (scope.rowNo == k) {
                            tElement[k].click();
                        }
                    }
                }
            })

            //监控传入值的改变,同步关键字显示
            scope.$watch("value", function (newValue) {
                if (angular.isDefined(newValue)) {
                    scope.searchWords = newValue;
                }
            });
        }
    }
}])
.directive("inputYiZhu", ['docOrderRes', '$timeout', function (docOrderRes, $timeout) {
        return {
            resctict: "E",
            templateUrl: "/AppScripts/components/inputFreq/inputYiZhu.html",
            scope: {
                value: "@value",
                callbackFn: "&callback",
                required: "@required",
                searchwords:"@"
            },
            link: function (scope, element, attrs) {
                scope.rowNo= -1;
                scope.len= 0;
                scope.focus = function () {
                    return scope.showList = !!scope.len;
                }

                scope.blur = function () {
                    $timeout(function () {
                        scope.showList = false;
                    },100)
                }

                scope.keydown = function (event) {
                    //var e = event || window.event;
                    //var keyCode = e.keyCode || e.which;
                    //if (keyCode == 9 || keyCode == 13) {
                    //    scope.showList = false;
                    //    return false;
                    //}
                }

                scope.change = function () {
                    scope.showList = false;
                    scope.len = 0;
                    if (!scope.searchWords || $.trim(scope.searchWords) == "") return;
                    docOrderRes.get({ currentPage: 1, pageSize: 10, keyWord: scope.searchWords }, function (data) {
                        scope.items = data.Data;
                        scope.len = data.Data.length;
                        if (scope.len) {
                            scope.showList = true;
                        }
                    });
                }

                scope.rowClick = function (item) {
                    scope.callbackFn({ item: item });//回调函数
                    scope.searchWords = item.NAME;
                    scope.showList = false;//隐藏列表
                };
                //根据关键字过滤结果
                scope.filterItems = function (item) {
                    return ((angular.isDefined(item.NAME) && item.NAME.toUpperCase().indexOf(scope.searchWords.toUpperCase()) >= 0) ||
                        (angular.isDefined(item.ENNAME) && item.ENNAME.toUpperCase().indexOf(scope.searchWords.toUpperCase()) >= 0) ||
                        (angular.isDefined(item.PINYIN) && item.PINYIN.toUpperCase().indexOf(scope.searchWords.toUpperCase()) >= 0) ||
                        (angular.isDefined(item.MCDRUGCODE) && item.MCDRUGCODE.toUpperCase().indexOf(scope.searchWords.toUpperCase()) >= 0) ||
                        (angular.isDefined(item.NSDRUGCODE) && item.NSDRUGCODE.toUpperCase().indexOf(scope.searchWords.toUpperCase()) >= 0) ||
                        !angular.isDefined(scope.searchWords)
                    );
                };
//按键盘

                element.on('keyup',function (event)
                {
                    var tElement = element.find('table tbody tr'), indis = 1,len = tElement.length;
                    var e = event || window.event;
                    var keyCode = e.keyCode || e.which;
                    for (var k = 0; k < len; k++) {
                        tElement[k].style.backgroundColor = "lightgray";
                    }
                    //Up事件的标识代码
                    if (keyCode == 38)
                    {
                        e.preventDefault ? e.preventDefault() : e.returnValue = false;
                        scope.rowNo--;
                        if(scope.rowNo<0){
                            scope.rowNo = len-1;
                        }

                    }else if(keyCode == 40){
                        e.preventDefault ? e.preventDefault() : e.returnValue = false;
                        scope.rowNo++;
                        if(scope.rowNo>len-1){
                            scope.rowNo = 0;
                        }

                    }
                    if(tElement[scope.rowNo]){
                        tElement[scope.rowNo].style.backgroundColor = "#FFFFFF";
                    }
                    //Enter事件的标识代码
                    if (keyCode == 13) {
                        for (var k = 0; k < len; k++) {
                            if (scope.rowNo == k) {
                                tElement[k].click();
                            }
                        }
                    }
                })
                //监控传入值的改变,同步关键字显示
                scope.$watch("value", function (newValue) {
                    if (angular.isDefined(newValue)) {
                        scope.searchWords = newValue;
                    }
                });
            }
        }
    }]);

