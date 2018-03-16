using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class GreenGrassItemIcon
    {
        private static String ENCODED_GREEN_GRASS_IMAGE =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAAAXNSR0IArs4c6QAAAAZiS0dEAAAAAAAA+UO7" +
            "fwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB+IDDwoEJjNtv4AAAAAdaVRYdENvbW1lbnQAAAAAAENyZWF0ZWQgd2l0aCBHSU1QZC5" +
            "lBwAAEdVJREFUaN6FmmmMHNdxx3/vvZ7uOfacvbi7vK3lfYsiJVqSdQs+ohjxEceOg8Q2jCiAgThfgiDIh3xNgjhIgORDYARO7NhKBMci" +
            "IkuKbUokRYrLc3l7eXPJ5XKP2Xt2ru738qGP6Z6lkh707ux0z+uqV1X/+lfVitf/6gXDxx3CP4UEYQmEBdIRiJRApgRCAsq/RwqJFIqUZe" +
            "NYGTJOE83pNtqynXTkVpDP9ZBzWlHSSjyiWqtx5vwQ7x37IQvFSZycorujnVxThqmpAqNjkyzML9Lf28WundvIZjJMFmZ5570PmJ0r8c3" +
            "f+xzHT5zFAli7/lWUUnieByZQABAIhBDRZ8YYDIHe4X3G/zw6XPzvLEkWhWBJSMYoAIXou+H9xVKRoUsnWFy6xd59mxhYv4fF0gK3b97m" +
            "7PlLLCyW6VuR57nnX6E1k2W+WOb8xesc/vAKxXKO559eQ7nsce3WA18RJRU3r/+c//OQ+BaxBcIWSDuwivKtIhAoaZGyHJxUmkwqR9Zpp" +
            "SWbJ5/rIZ/tpindRkrZCCEZHbvHwf/5MV0dVT7/+VeZW1igMD1BqbjE/FyJx3fvYtPAY6zqX4VrPK7/+jZHPjjO2H2bz+79KpfH3mXv7s" +
            "1cunoLT+Mr4nouAJ8Y+Azd+W7fnYRABKYxGH8XDWijfWuF1wO38t/WvyOEf02UBfNlWCgsYSiCgcnp2wyeeYee3lY+/exTlCtletN9CDQG" +
            "WLNmgJnCDLduPuTUicuMTxQozCs60zv5+msHKJo5Rko5NnxiM0NXbtPd3e4rEj68u6Ob3s5epJS+IIEbGGPQRtcVCgT140ImlFoeZiKheG" +
            "HmPrfvHWfFSofOrizj4wXSqRxL7gKeASFgYb7M3KxHxuphw/qt7N++iq6Oftpb2lEpxcFDb7B16wCtHe3MzcyxdlV/oEggtBQSpZT/0CA2N" +
            "DoSyBgTCSSljGIo/CyKAQzCxBQTdcVLtWlWdK+gqytPU1MbaasLWzkomUZJG0GaVH8apRx/o6SsxyXgui7Thfvsf+YxNC5Vt0Z/e85XREp" +
            "JGCtKqkgoI3x3CheKdlcmtz4OAobABYVGGt/lpJGRwqt7d7Gubxe2lUYg/efFrY9B67r1415gMJRKS7jePK0tG6hWqmweWENvb3cQ7EJFF" +
            "pFCRgJqrZNuEjwwQrFA6AiJRB2RBAIjDBIZrSuFL7gSKvGZEb4F4+vF140r4uoKnZ3N2BkLz3Pp7esmnc0mLRL6exwiw0Xj5g2vR5YLBIj" +
            "HQ0JwpSI3kcjILRvXjyyAQaMjJZKwbcjkHASKlKXI59vJZTPJGGn09chVYsInlAl2Mn5vKLAlLJRUSOkrE25SZPHAoiEKRoBiHqFEoKjWGs" +
            "fOkmvOUCkVaerqoCnXRqm4gIz7fhxqGxfBxJJf3PxB9pdSYikLS1qkZIqUlSKl/NNSFpayEm4bR0NPe2ij/fNjlIhARCp6O9YyP7OAUhYdH" +
            "R1cunrTt0h4ozY6CrRod0LYFQ0BH0OsRAwoFYGGEr5F4m4XPi+0RORW8Q2MxUR4hMp6xqM528uDmRHK8y6nTp5D4viKhEEd7kqkiK77Z+RC" +
            "IqlEFLhSJoQP46Exv8TzUXzHP06B+MZ62kNrjZ3qRnsZ7o085O7IBF/5zDcCRYLd0drXOB4PApHIBeFptMHzKmiED6Fa4kpQBHEhbNJOJgmr" +
            "wXOWKgto7QUKAMa3uNaajNMcWSqudOgtrnbxtMB47RSWRujs2Miq7i1YqEARSeROceElcrkVUDwo3Obdy98jvzaNaMjo1UUXdXczX//iH9dh" +
            "NBBosvCQd+78JU5zKkqwxhjciub6sSm+85W/J5drSSKY1olY8i3ZxkB/GwtzBYSUWDIVZPVU3d9FTLLQNRQKIQVCCiSS1X0DtJ7aipJ32Nv" +
            "7WTzjYoxGCEnFXeTtq29zdfg8Gwa2JYL7yK3vs/exl7FVNgarmnePvUm33ImVcuqBH4/T0CrBe0tl2LB6J0PD7/nyy3QQrOm6v4fBmpI+4qS" +
            "sFJblI48lLB+hpMWXPvM6l96b4tbMGSQycB8PSzrseHodhwbfpFwp43m+bx8e+k/aVtg02e14xkUHbnxr9iz3PjK8+MJvoiwVuI8XuZLWvjXii" +
            "OmTUoMSCm00UjqBAo6vkCV9/LeUhVIKS9aFV6KOSEIK7LTNF5/7Luc+usxM+QFSqMAFJX1NG6jlR7hw6SQazdTMQ8rtN9nU8RTF6mwMjWq89y" +
            "9nGVi9i96VKyOQ8bTnC68NnvEiV4sDjOvVUFJRdUtIaQs/89oiwntLWhH6CBljuTIg6kZEOWXrtl30iL1cvD2I65UjAXN2O9t3bONnv/oniotF" +
            "hicP05PrZ7E2G5BDgSVSvHP4p9jVLn77a38Q7XwoeOhKIXwLROQxlrQo14oopViqLiKF5ZNFkaIOmzFqLv2c6f8dMNqIlgS+/4XXvoV3v4fRhW" +
            "F/1xB4xqW/eRPr9jfzo4N/TTV7j/ZMf6SoEhZXp45y6RfjfOOb303ERYhQCbqjZH2jlYVlWUwXJ1BCUVh46MsZ/EhyrTjneRQTNfViy0pZbFv" +
            "7HOc+uozrlRN54MD2V9j1Uh+buw7g6mq09mx5jGNvDfPVL3+Hzp5uPyao5654sg3jNWQKtmVjK5uphQekVIqxuTvIRG6IQV3oOstOkpQ9rD" +
            "127zxAX/pxzt1/HxmwaYCUytCdXUexNp9Q8MroSapjTWzavKO+KTqwQEAslVA+1QlOW9k4KQfbslFKMTZ7F6UUD+dGfL+J4E3rZEUY51Xxj" +
            "NvIuYLPXjrwO9w4usD9+StIoSI3iysgEEwu3WHwJw/58le+hZ324dbv1gR5KoiBcOdtZeNYTqSErWxsaTNTnEQJxUJ5pq5IgoES41hxIYLk" +
            "lXjFFG9ubeY3nnmdc6cv4OlaveY3OraG5JdvHeOx/sdZP7ChXgfhW8CSPtzblo2dsrGtuhVSKoUlAgIqJWV3CSkkNa8akMYGjhPS8UQxFb/" +
            "PJAuqOJVob+1h5ZY20lYTFW8pguM43UmlJR0d+TqgBLEZkU2lfIGDVBBei/M2gYjyEMYg42QtSjYNXYTGnQ9rhjhlCK8ffvA9tnc9FwV2fD" +
            "3/Ps0zr+xnunKduZnZCIVSyo8B27JxlINj+VYIryUYR1RamMgtQyLlP04IGl/xOiRBFfRy+nD0whtsWb+DZqcDz7hRfIh4HYKhO7uW9s0lB" +
            "s++ixQyQqIwoMMaJrROqEAIza52cT0XA7jaDdtuse5o2D0RJFAphOFQgcgSpl7HjE/fweu8Q1d2LQuVQqSEEhbz5fFEz0sKxfbVBxgtDzI+" +
            "NrqsAIvYg6gn3vC5NbeG67m42ud2IYXxKaCQCFSy8RaLC60DfDdJEAhfrlfj3MhbDHTsp6YrSJnCYMhYOX519qf84B/+i6tTRxBCRgo2OZ1" +
            "sf3ID//zmX9SFF/WSOFzb0x6udqlpX4GarlHz/Pdo/DavBmnJFEIIUsqpWyJWPyRQrKEhEfr/vYlL9K5pIyUdnwEjkEJxffoUQ28/4PPP/x" +
            "FXT4wyV36YYLwb8k+y+VOdfO8f/9wvwsJcFtYeru9CNc8XvupVo78942HcoO/mCWTayiIQpFPZj0emBggWsXiamHrApdJ/0Ne0kZquRPFQd" +
            "Yuc/OA829Y9zbPPvcju/te4cu9kpKjB4BmX3eufxeu4z6lzH0Y1h+d5vvDB7kfu5LkJt9ZVP0/pqkFmnBxSSLJOUyRgY+uHePzE+Y+UnBz9" +
            "IXv7P53IFZ6ucm36JLPXHX73a3+IEIJ9O19kbjjHw+LNSFltPLJ2G3sObOcXp3/I+PhY3ZUCK7jardN6kl6hKwGvK2lkU7oVIQS5dDNCCKr" +
            "VJSambuO5tQRmx10pfB299AarV/eRTTWj0ShhRfTkyL9f5+VP/RYtLa0oqcjnO3li4HNcvngVYzSWSKGEhUCwsmULK/Z4HDv3LuVqKYqB8Kx" +
            "Xhcn2q6kEFWbFYDVn23CXJK3ZDrxKhUMf/Su24/D0E19LNAQa88vY5C2KzcNMTs9z6fqZgF7412Yflulr2sIzT7+cAI8D+1/gl3/3BkdbDh" +
            "IPt/B7Z278N5/c9yrZTPNyl0bUy4ggieqar5SugdWe7WYSaE23cuL8zylM32bf7lejFmZisBPL+q7nce/9NN6S4/eCRV3RjJXi6ZdewXGcR" +
            "AfFGMOffPNv+P6//S3GFdGi4Wa1iC6EkFGCbYzHeMNcCglewDw0WPlcN1NyiqGLx6i4c/T0dqJSpeR0KmyOxTL0qhUDfPv3/5SoDIjV9411" +
            "f5wCpbMZXv/2nyWYQhi80TNMfeYiqRd08QafaOh4WE1OG/cm3mFi7j4vPfsMY4UJlrwCHlUE1jK3ih4QX5SYRUQDWzbLWztxRhDfsMhxwia" +
            "ITP796DFnINf03AQjYxd54VNPcXf0Hq3NadxamUplbll5GVaQPoEzCcIXN3uc6ofdwTgriLdIG6E9qlJjDe/GZzzKIvLDk++yb+8Ould0Mj" +
            "I6guM4FBdLTM88rDeglf/baE1h7g4Xht/m0IkfcPnWIYQ0y9hAomupl/d4o+59TLhI4MbNYfnaiXZV8N6S6Qpbtu+kuDiPApx0itGHBURth" +
            "NV9O1FK4Xoud8fPce3GIDPFEdJph/JSFTstwNQAJ4Fuj2qFhiVzfPSd6CPHmoLxeUsEuTG3axxOAVhPPrkDSwoKhWlSKUnGacYYGC9MIoRh" +
            "YvoGx88dpFqeYuXafnbse4rZ2SIXhs7S2dGMkQbj6WXI1jjJiuLH8OjYilGfOjWXiVwWH7qGw6nwt3Xv/h02btrEyJ27OGmHXCaNJRUzsxN" +
            "cHH6fw6cP0tfbzvMvfZKOjlauXvs1v756nZ6+FZSrNTxXIhqHQBiMNghhAtlNgjA2Ho9qbgjhT7zCgiq0hBIqcsUIfABrbm6RmcI0E+OTrN" +
            "/wGEZ7ZJvS3L17m5MXx3n6qe1s37UdS8K14esMDV1gz65dVKuSwlQJbfB7jMaA0GhqeGaOYmmKWnWRqlchm24j3zaAqdhRnohXl4kReNhzN" +
            "jFrNIwupJD1cWGgkCWV4NrwDUTKIt+aAyGwLahUp3jhxS+xft0aAMYnHjA4OEhfXy8bN2zmyOETzBRSeK6LUVUmF4aZmLzC+NRD5udmcd0q" +
            "yk6RtTO0tLexe1OGTGo1mFQib4TkNOrIIJaVtHFAaKyZojziVWvcuHWbvr4VlMsuHorxyXF6V65gVX8fAJVqmePHBkk5Fpu3bMEzgmu379L" +
            "VupEb99/n4rUPsVOGfGee7t52shlFYabAho1bQXssLdVw7IwvvG6YSoVB3UhQQ0rSgFwRqTXJZGsNXbhMLpcj35UnnXYwtRqF6Wn6enuwLF" +
            "/zK5euUiwW2bhhgI58nmJxnumZKTLpJu5MzLJv3w76ervRnuatgz9n9MEo+5/Yy+pVfZw6d4YV+fVI2YpX9RsGIQSHNKgxEcanv/FqMZz1x" +
            "zs/4TzHGhuf5NMvb8fCoqWljcnCJKXiEq0trXjGMD46yvmL5+nu6SGXy2E7ac6dP08u6/DCc3vo6+sFBLPzs7zx4zeZnplm//59PL7nceY" +
            "XF3kwOkNXrot796f9YkgnrRANScMEGMZBfOrVkGwNhvGp8YRCVr49j+MoSkslMB4XL17CdhRNrRnm5+c5dOgIlYpHS3MLKTvDzOwch4+eo" +
            "jPfip22qXkuc4U5fvLmzyguzbN//z62btxEpinD4aODCC9NV08zi9U7zC8VWKzOU6ouUKmVcHUtshAajAtexaDLBl3RforS/8//+oSotX7" +
            "dKpZKFZy0w+Xr1zk+eJqBx9ZiCTh96jz374+xb68/rEmn0/zqgyMsFOfZvm2AG8M3Ubbk2PGzSAP79+yio6uTjp4erl27xeDpYVb37eXq1bm" +
            "gmOoCusggyAUtUalkfe4Y/sOCWD48jfO10BJKKqqe33aysrZNpVpjdGycC+cvk8llyHd1Uqp4nDh5mnVrV2I5WcBwdmiI8xeu8Im1q8nnWyg" +
            "Xy3x0+Axr1q2lv68bhaC4UGTozFkOHzvL5tVP8IXXvkTVLDKxcI+phXHmS9OUKgtU3DLauBg3DHp/903NoCsGr2QwVYPxkkn0447/BTRrySN" +
            "kFDGjAAAAAElFTkSuQmCC";

        public static string _ENCODED_GREEN_GRASS_IMAGE
        {

            get { return ENCODED_GREEN_GRASS_IMAGE; }
        }
    }
}
