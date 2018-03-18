using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class GreenGrassItemIcon
    {
        private static String ENCODED_GREEN_GRASS_IMAGE_NULL =
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

        public static string _ENCODED_GREEN_GRASS_IMAGE_NULL
        {

            get { return ENCODED_GREEN_GRASS_IMAGE_NULL; }
        }

        private static String ENCODED_GREEN_GRASS_IMAGE_EMPTY =
            " data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAAAXNSR0IArs4c6QAAAAZiS0dEAAAAAAAA+UO" +
            "7fwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB+IDDwoFCPaggw4AAAAdaVRYdENvbW1lbnQAAAAAAENyZWF0ZWQgd2l0aCBHSU1QZC" +
            "5lBwAADq5JREFUaN6FmtlvXEd2xn9VdXsnRbK5k9Zi2dRiW7Zsa6RxMpudSQYzCQYDBAMEAZKH5Cn/Sv6LBAEmA8xDYiD2OEA0lsfWSF5ka" +
            "rd2iRJNcWmSTbLZ271Vebi3quveJmcaaLDZ7L73fOd855zvnKL4l399z7DfQ8RPIUEEAhGALAhETiBzAiEBFX9GCokUilyQpxCUKBUGGCwO" +
            "M1weY7QyRbUySaUwhJJB6hadbpevrs7z0Wf/wXZjlUJFMTE6QmWgxNpajcWlVba3dpidHuf0G69RLpVYrW3y4Ucfs1lv8s//+DdcvHSFAOD" +
            "I0Z+glCKKIjAJAEAgEEK494wxGBLc9nMmft89QuLv7Ep2hGBXSJaoATX3Xfv5RrPB/I1L7Ow+5MzZE8wdfYud5jaPHjziytUbbO+0mJmq8q" +
            "N3/4qhUpmtRour1+9x4dNbNFoV3v3eYVqtiLsPv42BKKl4cO8D/uhDEkckLxB5gcwnUVFxVAQCJQNyQYFCrkgpV6FcGOJAuUq1Mkm1PMFAc" +
            "ZicyiOEZHHpKe//768YH+3wi1/8hPr2NrX1FZqNXbbqTd5+8zQn5l7m4OxBQhNx75tHfPLxRZae5fnrM3/PzaXfcubNk9y4/ZBIEwMJoxC" +
            "Al+Z+xkR1IqaTEIgkNAYTe9GANjqOlv17Qqv4Ze87QsR/Ey3BVgu2a7sYGmBgdf0Rl7/6kMnpIX76g3dotVtMF2cQaAxw+PAcG7UNHj54z" +
            "heXbrK8UqO2pRgrvsE//PzPaJg6C80Kx146yfytR0xMjMRA7M0nRieYHptGShkbktDAGIM2ugcoMTTOC5kC1Z9mIgW8tvGMR08vMvVCgb" +
            "HxMsvLNYq5CrvhNpEBIWB7q0V9M6IUTHLs6KucO3WQ8dFZRg6MoHKK98//mldfnWNodIT6Rp0jB2cTIInRUkiUUvFNk9zQaGeQMcYZJKV" +
            "0OWTfczmAQRgPmOgBb3bXmZqYYny8ysDAMMVgnLwqoGQRJfMIiuRmiyhViB0lZS8vgTAMWa8949z3X0YT0gm7zI5UYiBSSmyuKKmcUUbE" +
            "dLIXct6Vadf7RcCQUFBopIkpJ410gA9Nn+bFmdPkgyICGd/Pjz4GrXvR91lgMDSbu4TRFkMHjtFpdzg5d5jp6Ykk2YVyEZFCOgO11mmaJ" +
            "Dd0VSwx2lUi0atIAoERBol015UiNlwJlXrPiDiC/vX86/pAQt1mbGyQfCkgikKmZyYolsvpiFi++yXSXtQPr/27i1xigJ8PKcOVcjSRSE" +
            "fL7PVdBDBotAORLtuGUqWAQJELFNXqCJVyKZ0jWa47qnjGp8AknvQ/aw0ORICSCiljMNZJLuJJRG0VdAXF7AEiAaq1ppAvUxks0W42GBg" +
            "fZaAyTLOxjfS575fa7EUwXvPzw590fyklgQoIZEBO5sgFOXIqfgYqIFBBirZ+NYx0hDY6fu4DwhURqZgePcLWxjZKBYyOjnLj9oM4IvaD2" +
            "miXaM47tuyKTMJ7FSuVA0q5oqFEHBGfdvZ+NhKOVr4DvZywDws2MhGD5Wm+3VigtRXyxedfIynEQGxSW684ILrHT0chkQbhElfKlPE2H7L" +
            "9xe9Hvsf3A+A7NtIRWmvyuQl0VOLpwnOeLKzwdz/7pwRI4h2tY8R+PghEqhe4KNhq5OeAFCiUKx72q66sevngl9Zs+fZVhP3dsiXUIZEWm" +
            "GiE2u4CY6PHOTjxCgEqASJxdPKNl8j+KNDzugUlpHAJbYivoY3ulVHPoCwYH6xlQaqCaZ3KpTiSw8zNDrNdryGkJJC5pKvnenx3/cJGRI" +
            "BCIaSIDaYHABnTznb+bHVLGbpXAnvvW0emaG7S+WpfB6rEsUNvMH/nIwACWUyStZjmeyx4k2h4xjuhiOxrXD5Nfbmf5X4ffTzv+4YbY2Kq" +
            "e2LVXjYWpQYlFNpoAllIABRiQIEMYs8L4dSsVbIWjM99p8fM/j0npQAy1SkLAMDoGIAr0cn1nWZL8jOMuiip6IRNApkXcefNC1fvHbUE6c" +
            "gIEVevbCf2Ko69aUpEmkweeNHbL7n9yPhFx5b5QAa0ug2UUux2dghEEItFkaOXwJ4RKRmeKNq+JDWmp8sE/RQz/ZGwqjrlBB+INqm5yBYT" +
            "ByQIWG+soISitv2cIM7XOGldome7KWJ/MedJ/az3s1RKdW2PVjaPjDCgE+ljBzOE02xS9vRbXuVZ235ATlVYqj8m8HuDLXV76azUQsKXM8" +
            "nsYUSaYtmSm5XoWWVtneJHQCCc4LTN1v2uFAubTyipUzyvL/QaoqVHtsL4ndmPTkpzZRRyXx54nNekFYNT0t6AllLOSbMNVE+ESiR5mWej" +
            "scqAUmy3NtKd3d5MCOF+ZvMkRZlsYmbzxqtmfg/p22sImQaget5XQqUA2elUSkkr3EUGkm7USUTjHnXeKlW/Oab47+VKVj9ldZMhSVwj+u" +
            "hpAQghemJTKQIRK2k7QdrJ1V9V6UROYQxBitcmvTDYrw/YBLdUzGqmlGNMZsLMAEpVIhnEIGQaREr+p0aLpPcICHAo003Q537Ks9khyOhU" +
            "6czO+Hbc9ZVzb1UWV0ufPhaAL0RtTjplrjVhFGKAUMerrCC1HRW9Lt7XqfdoXPbPbteVGO60VwIi1YtETy04vnvlNZCB+92XOFaZRzru+K" +
            "EOMSZWw1prApG0e4FK5UQ2cVM9gbTs9ouAv9jzFYF9bRuuTdxso/MVtB0t/FkkNCFGm3ipqInXvBqCQOYQQpBThT3nh70UbTafLBg3Cfod" +
            "WaRVtVPMHhgpZRzFBIAxcVQdiCQSbiROomNC0DkNkSAoBmUEgmKuvH9l8ijmL7Ut/Xxh2Sc0vU2key3Sn+m7p+mNw1r35pBIR+mS3zGIkk" +
            "B3DEGpUEGGknJ+wF3cSea9dlqZva8fqew+OCv7/XEgG1mNjuWJPxEmjLB54VSwHYPbsROjpiYYKA4hGoJKcRAhBJ3OLuv1JapDs8gg6NHF" +
            "9FcdRymvJ1hpYRfbFkBfNcxuU9B9s4gvbfytjb2+aSf52TbIwfIwUkiGyqNE3Tbn//Dv3HrwCSjZJ/D+2EPEVvco429avNHZ32dFOiLUYf" +
            "yM0s/UWGsbp5RxqU4GQN2NWaC7IEfKEwAMFYe48s0HPF97yNTEoVgIZgYfv284Q62nJakp0jUykfa+1j3e22e8UIhSxvsl3UmXjFwhSii" +
            "vIahWJliTa8xf/4x2WGdyegyVa/ZFwQnGzGs3BmRnl72kzR6jrJ8LrnDsQ02/w6fyDAgGCsM8XfmQlfozfvyD77NUW2E3qhHRQfT6ZWpC" +
            "c4c7mQVFdoflbyj3m/58h/kVz3b1VHTZ//xFrtdXWFi6zns/fIcni08ZGiwSdlu02/WUd5yETvZYIvFeqqT6+eDJishEqVLqr0izpd0t9" +
            "7yFd/Yee0VEfvr5bzl75nUmpsZYWFygUCjQ2GmyvvG8t3xT8U+jNbX6Y67d+R/OX/o3bj48j5AmDcDbKLptZWbH67b3/sLPGrxXv8lcO9" +
            "sKknVQm1dOvUFjZwsFFIo5Fp/XEN0FDs28gVKKMAp5svw1d+9fZqOxQLFYoLXbIV8UYLpAYc+tSd+Ym5LCmT0yom87aZtuX6PNHE4BBN/" +
            "97usEUlCrrZPLSUqFQYyB5doqQhhW1u9z8ev36bTWeOHILK+ffYfNzQbX5q8wNjqIkQYT6T6lnD3Jcvlj2Du3vAZppbnVZ371sp+3h1P2" +
            "Z/D02WOOnzjBwuMnFIoFKqUigVRsbK5w/c7vuPDl+8xMj/Duj/+c0dEhbt/9hm9u32NyZopWp0sUSkT2EChZfQphEtsNQsi+s5e+o4zMY" +
            "asRxg1UNhJKKEdFV3yAoF7fYaO2zsryKkePvYzREeWBIk+ePOLz68t8751TnDp9ikDC3Tv3mJ+/xlunT9PpSGprTbQBaQ0QGk2XyNRpNN" +
            "fodnboRG3KxWGqw3OYdnzGnp1rsnO+PXd00RD9CtkdFyaAAqkEd+/cR+QCqkMVEIJ8AO3OGu/9xS85+uJhAJZXvuXy5cvMzExz/NhJPrl" +
            "wiY1ajigMMarD6vYdVlZvsbz2nK36JmHYQeVzlPMlDowM8+aJEqXcITC59JrUmNQZicuXzH9f2CikZia/j0SdLvcfPmJmZopWKyRCsby6" +
            "zPQLUxycnQGg3Wlx8bPL5AoBJ195hcgI7j56wvjQce4/+x3X735KPmeojlWZmB6hXFLUNmocO/4q6Ijd3S6FfClZvOm+/VbWqNRKKFO53K" +
            "yS2TkH89duUqlUqI5XKRYLmG6X2vo6M9OTBEGM/NaN2zQaDY4fm2O0WqXR2GJ9Y41ScYDHK5ucPfs6M9MT6Ejz3+9/wOK3i5z7zhkOHZzh" +
            "i6+/Yqp6FCmHiDrxwsCWYHuSm22EqT2WPTIX6Y2/paQ9zwmWllf56V+eIiDgwIFhVmurNBu7DB0YIjKG5cVFrl6/ysTkJJVKhXyhyNdXr1" +
            "IpF3jvR28xMzMNCDa3Nvn1r37D+sY6586d5e233mZrZ4dvFzcYr4zz9Nl6PAzpdBTcwGUboOgdILlTr0yzNRiW15ZTgILqSJVCQdHcbYKJ" +
            "uH79BvmCYmCoxNbWFufPf0K7HXFg8AC5fImNzToXfv8FY9Uh8sU83SikXqvzn7/5Lxq7W5w7d5ZXj5+gNFDiwu8vI6Ii45OD7HQes7VbY6" +
            "ezRbOzTbvbJNRdFyE0mBCitkG3DLqt4xal/8T/+tiqdfTFg+w22xSKBW7eu8fFy18y9/IRAgFffnGVZ8+WOHvmNQCKxSL/9/EnbDe2OPXaH" +
            "PfvPEDlJZ9dvII0cO6t04yOjzE6Ocnduw+5/OUdDs2c4fbtOkJIYBwYp4SgkkhyqWTv3NH+w8Iec09q6ZFEQklFJ+rEQMr5PO1Ol8WlZa5d" +
            "vUmpUqI6PkazHXHp8y958cgLBIUyYLgyP8/Va7d46cghqtUDtBot/nDhKw6/eITZmQkUgsZ2g/mvrnDhsyucPPQd/vbnv6RjdljZfsra9jJ" +
            "bzXWa7W3aYQttQkxokz72vukadNsQNQ2mYzAR/IlRCID/B9f6SvX7pM8MAAAAAElFTkSuQmCC";

        public static string _ENCODED_GREEN_GRASS_IMAGE_EMPTY
        {

            get { return ENCODED_GREEN_GRASS_IMAGE_EMPTY; }
        }
    }
}
