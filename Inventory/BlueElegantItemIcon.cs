using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class BlueElegantItemIcon
    {
        private static String ENCODED_ELEGANT_BLUE_IMAGE_NULL = 
			"data:image/png;base64,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";

        public static string _ENCODED_ELEGANT_BLUE_IMAGE_NULL {

            get { return ENCODED_ELEGANT_BLUE_IMAGE_NULL; }
        }

        private static String ENCODED_ELEGANT_BLUE_IMAGE_EMPTY =
            " data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAAAXNSR0IArs4c6QAAAAZiS0dEAP8A/wD/oL2" +
            "nkwAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB+IDBRQREcVgkoUAAAAdaVRYdENvbW1lbnQAAAAAAENyZWF0ZWQgd2l0aCBHSU1Q" +
            "ZC5lBwAAFg5JREFUaN5NmmmwZVd1339r7b3POffe9153q1FrQEaKQGKwmBQxGSwTQKBQDpYFGEOFhBiq7DiFMxCHIhUX5QyVkCJhiCmD" +
            "sZ1QuBwbZBQIlA0CB2LAVlXMGDFIIAlNCOn19N699wx7WPmwTzd5H7qqX7177j5nrfWf1pG3vuMPTAARQVRxqqgKbQiEoOwslqyWLXt" +
            "HdmjbwKr1eO/xzhGCxznFOYf3DhEQqZ8XEQByNgBSTpQMMWf6MZJiZjtE+mFisxk4WA98546v8Wu//FouvGCHU2e33Pbnf8FHPvZpjh" +
            "2/mFe+4oU8/ZqrcQLfuvMeHnfpcR7a3+CcQ0XxpRR+5/duQ7ShpBFRQdQjzmNlgmIghvMdzAcVEUxAzMDqQY1CWOyQpwErGfGeZrECh" +
            "DwOqHe40DJtDxD1IIogiA+IQRy2TJsHefu/+CW+d88DfOADH+DrX/8G377fI/5h3vR3X07XKPc/+AgP3H8fV/2NS/jg+9/JQw/cy9Oe" +
            "cR3ezHDtHv/gtdcRnBJTJqcIInhVdlYdR4/ucnRvh53lguVqwbJraJqGtg2E4PHe0XiPOsWpQ1VQVTDDEMwgl0IpRkyZYZzoh8ThZuD" +
            "gsGe96Tk43JC2+6SUOFj33P39u9Bml5tuup77776DYxdcwN3fu4v3vf93uef7d/Kqn/sU7/+td/DP3/qb3PGd7+NrA9R/P/ChL6JhBy" +
            "xDzpiBBIdzDaVEfLPEdUvyuEZMEAVEQBUAFcfuZY/n8IG7MQrtYhdtW6b1GaC2ruWImYEIogGssDh2grMP3c3lRx7lda+8gWuf+nju+" +
            "1EhWeGOj9/G2/7Jqzl+bI/bv/R5vvDFryDdZbzzvf+N17/27/Cbv/EWXGjwACUN9SBhB3U75BSRUHtfRHFNg3eB0C1J04awPAFWAEN" +
            "dwERwPuCaFnG7+MVxwmIHUSPsHSNHZXHsOP3pRzEP3gcMBStot0sctzQ7l/Kdu+/k7f/uPfyHf/3rfOHTH+Zg3XP2cMuJ47ucOL7Hav" +
            "cI0RaU5PjgR77JFz7/GX76edfyS298U20tcQ6ovV5KRJ0i3uFcQJyvFSqJ2J+dawfiHKIeFxpcaLCcsJyZzj5Cu7sHBpYTcX1Qr5sy" +
            "zreI85QcCU1DjJF0eApxHhWh3buM2750D997/T9jtQgMm9OM27O88lWv4g2vfw2UiWdf95P85ddP4tsjXHCi4drnvohHTo94w7A01YE" +
            "tGde2yIwEGgI5DjgfUHG1CqqIOFQd4gLqPDmOqG9qdeJEe+QYw6lHyXEihID6gOWCiJBij2rDNIxQImaFkhK+W7I4/mQOT36Xr961xs" +
            "qA7y7hKKe5/gXPYb0duPHGl6F+wf+580+Jm4e5+abX8ok/+QMeevBBVKSOiM5ohVVkql8wIigaWoyChoCoA6e40KLqKbmgLqAqLLzh" +
            "uwV+tQLR2mpzy6GGlUJol0DBLJOmCTPDyog0HZREd/RKFkefyPL4NcRhn/e/+21cdtlj+eitn+Yr37iLpz31GkrssTTwvGc9lTf/o19" +
            "hb3eFehEsF4L3WElAoeSIaG0iv9ilxLG2ihkaHL5ZklMi54hIhWAxxdoVu3srxv2T+OUCMyOPI83uUSwbrltQcsaKUeJUn6A4xC/I2z" +
            "VpGikpgjqyjfzijVegKnzj2/fy79/xXv7vt77LqbNrnn/tRZhlPvO5L3L8xGN517vfg3Zdi1liueig1CclAqUYrt2hpBHLeZ6LgNOGN" +
            "G7q70qpwOAUt9zFimAlU+KW3PfnSXaxswJqRQDECiCom4kzF+KwxjUtzZHHYBjbH32N19z8Ei697Apu/cRnOXX6gD/66Oc4eXrNa1/z" +
            "tyll4va/voP3feDDfPPb30O7NmAls1p2GKVif06oc1iewBIaGvzOUSxH4tBDAVFBveLbDvENJQ1YHhm2WxaLlmMXXoBvW9QJNq4JWrA" +
            "04CxhJRM8LJZLxCIlj5WLVnvk9UmcD1jpGcfEt+68n1tv+UMk7fPtO77Kx2+9hac/5fH89jvfzLafuOXjt/PJz/41frlYQCl0bYtZmT" +
            "HJEARLCfUtLjTk/nCGW1+HPPj6hE0QBA0tSqENDQfrLYsYWR45ysH+Scyg5IxTRci0rSdlJccJ7x04D2mgjGtiTqhUxOuWuzz8wD5v+" +
            "Huv4zN/eivXXvccPvVn/5tn/c2n8/M3/Syixp//r9uJ04hfLjqwQuP9fAvQHr2EdLiPaxagQp6qxBD1qIKRsVQQ3+KaDiyTxw0SOnLs" +
            "WS4XaEmkKWJxoqSIc0IpUIrUFrUI4khJkaknF0FypsQJkUjXekSEiy65hLYN/PEf/i5XX3UlP3H5Vbzrvb/P3fc+yJve+Hru+tonOHl" +
            "mg2/bBsPqcJuhPhAP6k1YTpgVXGgry1OllzqP+gbXLUnDBqzg2yVxHLDgcblnTGCxsLjwEjanHiWnMv/dglIy2ZQ0jpQYCU1ApTBuD3" +
            "FhQep7NpuR7373Ozz5ac/mgfvWXP/CG3j5jTfyw5Nr/u27P8FHP3Ybw7DhZ376BVx88YX45XIBZoQQqhgs4NolVhLiPIJR8oQ6jyGoe" +
            "FQrf8TD07UJncPIiA+MwzhjOkgpaOMpllHnENchAmkGCrWCdivSNNSqdbugHplGnD/CD37wA1760pext3o6N7/8errlks984eO0q8vo" +
            "MR546CRv/JV/xT/8tTfjm6apzOoUbXfQsKTkoXJJMpxzFQAsoeoRBARSHGuJzPCuQTRQpgEphgHqXW3VmFFRumMX0p8+SS4JSgGBsNw" +
            "lDhucgnZL0rDFZERE6C64mo9+6pvc+f1/wy++5iYcl/M7H/qv/Nnn78R3x7Gy5Xkveilf+vqGC46fwLdNA+JYdAssRbKscb6BUhCnpDT" +
            "gfQPO1UMwSxoxioEPLaYVhq0UBAMTUIeokKeJxYUXk9YbsEwpBfUBVUceDquQ1CpREENwhOUK8Q1npsDnvnbA575yy6xrA759DNo0WBx" +
            "Zdg2+W2IC3nuHNju0TYOViFimpA2Y4qTDhwazDFmxMuEWu5UwUVQdZgUpDrMqN5hNVbNckVOkzG1jOQGCb1qsWIV2FyAX/GJJ3Bzim2V" +
            "VGaHDbA2lRVePQdsFpFhntNQuSFHwTmvLAhpCNVDdoiFPPZQEJqhrQZUUR0rKlDTi20psJSaKJcxSZWqzSmwCqgHXLZg2hzgfSP2WPPR" +
            "VxzUtoFDyLFAzfrmkDD1hscC3DWCE5RFkBh7XLlHARFHVOgKqoI6m9bW1vUOb4MnDAW3j8TuPwe1ciPgFZhlLIyIOcQ2Ip5SMiYKAxUS" +
            "O03mViwZc6ECE1B/S7OwioaEYWEr4bkVJGSwhWs1Wu3cMcsF1HSVncppQ1yBkNAScC7gmYMWQksnnWlcMVaUNrtJF41Dvqprt2habBuL" +
            "BI5S4BXVou0SbBVYirl1hZqTNWdLYk/NUNVPJaFu5qKQJs0xYHWEaNpQUUXXoYoGp0HQNgmIo7ZFjlDhhGGUakVJwLqCWGU4/QljuoqGp" +
            "IhY9L//zDBQwk3jKdE2DqjrUdzNhjdXxIVAyZapftLriGvzuEdJwSEm5zowJYe8Yqo7UbyhpBDNcu6RME953pH6LeI9NE+n0Pn61A87h" +
            "24Y8jVhKlDQh6tDQVGXtPS4EDDBLWJ4wKlFaKZQ4EadISZm2UfI00QSHVwXECD7MCYivqOIDFgeEXTb3fbuSoDokdITFLrlfU8aJPG0RJ" +
            "4h0uHZJnkYU0KYhx0iOVUeJ67AZrsWF+nfqEXUIQlEQVcowYCY4VawYeZpnNNfDW4mI70jDliZ4jELTeDQXQyRXBp8doahAMfzq+Hl3mI" +
            "d19ZC5ENenCasjiK+e24cOcZ48rBEzxCkWI65taLrqSQrQ7BxBfSBNQzVprnp9k3rdMg51/spImUb8zh6UaissJ0oZMDNKKeSSCbPe897" +
            "hxxgrQlEBJSx2oETEN5hNWB4R8bhuMV90QH1DmraUYYNvF4Tdo7XPpZlNlqJtQ5kiZf5iVBhO7SONxw57RBxGqdWoIh+cw+KEFU/JCdd0" +
            "lJLBCkYGHGhTvUxKBF/1m6rgDw8GfGhwzhEWO6jT6u58oOQJ8+fkfcEko02La3YgTTSrPSQE4uEBqsrRx19F7Lcgynhqv5JezrX3SyH1" +
            "PSUXLBtoRtsGKwXLVcKUOSMTZ+QYkaYgpqAeCkDESqKknlJ6gq+pjHeKP3O4QZvAFOMsKzJ+saoCUlosxyoUtX6Rb5eVB8IcTGD4pkNUO" +
            "Lj/XsyMI5c9jkEMt1wgUyBu1xUE0lhtQNdiMWK5AKWyutVoqYYdQJ7Ot11V0COYr4mPZcS19eGWVJFxuxkJix1SLKg6uiMX1IOJogLqA9" +
            "57IOGbBikRFwK+7QCj6XYR7yg5VVcpMB4cIKLE9ZpSEssTF1WyK4blXGWJCJZmP6OKqIKrgFNyJeC0PaicI4aIA61VERdAQr1xcTgVdJz" +
            "SbGUNv9yZvXnVVAgguQq8bgUlzdmVYhi+XWB5hLk1fGgoKCnH+ToF33b0+/tMmzW+61ieuIjVxRdVJeDmfDhV1yhlbsP6YUqK+NUeArjQ" +
            "1ur5Ja7Zgxwrd+UBwdCUM+odZ9cDxFhLWMosBwRVh2ta1HnCcq+SVM740FFywkyAghPBOWXvcVegJiBSucEHfNOgTikp0+8/ynb/JHtXX" +
            "IHz4cc5p1nNg1UQlWrYxPDtLq5dzSZuUXOEuK5SqcwIaQXNuYYCw5jACSpag2qdY6LQ4NsF4v0s7WPVRyXWJFKlhhVWSLkwnj6NFatZmP" +
            "M4X2VEWO1QckKdp/Q9w6lTWE64pqnOs+3m0KOgGmqM5ALifZU+JSLiKNNh5R6n5DJbcgwtpQYOm+1IHkcKhqmAeJBz+kkhG6KKBkcZp1l" +
            "2C8EropVAxUqdlVj9DGaMZw8oaWQ8OAsila/aDqU+/RInLGfSdktYLlkeP0F75GgFZBHy9rAqhmaBlYy6ABVYSVOsI6GKz9lI00A/jpRS" +
            "sFQwVawMqAvEfgNA6JaUOFKstpGZxymkUlVNnkbOxa/iAnHcYikRVjvkqcCMfDkntGSGaZylSEJbh6BMmw05n4Wc6oGB5YlLOXzwPtL2E" +
            "JGqsxSliDLGCdcdwzeKFsuklBj6OvRp6on9mSoPxpE0bPDLHcxmV1gyOWcsj+Q0gdSnWuYI6ZyKLXECs7qiiLlCajEsVnSrT7mrvyu1kpY" +
            "zMqtpm2d1OH2SnZ+4krBzZDZ0WiGcwDRGShoQA7/ZbIj9We6950760/fhFxfRHrmINI1zj7aMZ/brWkCERAUCUyEs9qqHmVcG535KrEml" +
            "YeRhBLEak6rUniiFYoXYbyhWZo1iczo+L44s45odSs70P7qfNKxpVsdJ/WHdt+QtY0yIZWLO+Ece+j5v+Pln8uynX84TfuMXeOjhfT5+2" +
            "7e472SHdHvk4QB1Dih1NecDOs9PnirBmVmVG00grteoq9GSyKwSmq56l1IoyVBXQSOOA2FnrzrIYpgqUgx1zUyODtKIqCcsVqShR9RhO" +
            "dOsjhJjAlXGIeIf99jj/P3X3cw4ZYb+EHEdV17xWN789k9QUsY3ixrCS91n5BRR32FpxDcVCEqc8IsWkVDljNR49Rwg5HGonxOtN50Lx" +
            "ey8dLGcz/e+hhbzGfUNsd+cD9T9Yo809OevPx08wjhVv7PtR/RZ1z6Dh/cPeOuv/1NufOmLydOW51x3Dak/g5lUls0TxTJWBPVtFYhm5" +
            "JzJQw9OZnKc8L6ZY6WM5UyOczCNVTBgDsOlwnbOCRGpfe+r5NHQ1kA7W82IfUOZtpWfhdrO4phiAitstj36wA8f4fjRFVdddTXPv/7FP" +
            "HLyLMuuZbX057dSlnNNSJyDYlXRWiVLU8OHZj5wqjIpRSyNmM5b3tAAUqsxJ32G1qWrGe3RC8hTJI896gMlJcoUEbMKHsO27mnaBZji2x" +
            "VWImM/kuNA3/fobZ/5LJ/+3Jd59gtu4MyZAx559HRNw4cEOs+GuPO7kzwvhTR4VIxmsUeeBkRcNUGloN7jFyvMSpXnzKLQKheJqy5Qnas" +
            "9fnj2fEY2bjdVUJZYOyFHSs6otvPcQUlTTSTnaKkfJ/zhmR/yq7/8q7zoJTfw5S9/lbf9yxMcHG5pmg4fFOfdefsrYvgm1AVPSYTlAisj" +
            "besIi4YS60wgjtT31TGXGoSrarW0zs1IVX1KSfXAP05YEtM0zpLFUA3gPGXaUnKFcRda4jYxTiMlZ8ZxQn/qBS/kCU98EsUSN7zkhTzjJ" +
            "6/EOwFt8cFhYYdmsQuqNbhDyTnjQiBOkRgrEcZ+Q9sESjakRLxXus7TdR1NE2Du/5Qr5+Sp8tC5VtNm9vGz0kAU36zQ0JDHLaUURD2FTB" +
            "oPsRzJ2TCMlCJ65ROexM+94mU8cM+3eOnfei7bfuQZz7uZ5cVPIuORPDL0fc1sU6LgMHEU/Gw/C7iGsR/mtQMUUcw5YhJiTExDT4kjJjO" +
            "0WsbO80UNwKf1AW5OY1zbzclmZtqcpqShqopSK2IlU0qsQIEjp4JO08jYb3jKk6/mRS95Ce/+rd+ju/CZ5FLwu8fqes0ipVQ7mvOEhq4G" +
            "C9U4kovgXMM0KUatmuXK6rPpO780LbGvLVSHgtAtieMWFzrCzl593WPcIGZM60fJcaCUTNh9DLk/qGtAcagGYsqIelLO+P39R7no4kv5m" +
            "Z96Jn/1V7fzzv/8PtqjV5OnnvbY5TgXyCY4Sg3PfFOTepW6QtNQPXzu6//F6u7E+fOvaNQbcTVEsFI3xqq4ZknKkbbbpZRE6jfEcYMLS2" +
            "J/gGWrMbIo08GPavKvAfKcL5/f6Bj+f37sI7zlLf+Y5z77Om782VfzpCuP8Yxrn8CDD59m94LIXQ9uOD0cQcTjQx08m6V2BaNUU8k8ISi" +
            "lKFZy1UTzTZuVuk9xzWw+9LxN1mLENGA5kcYNrtsl9YfVv4uiLtS2tPoZQ8hxIKWBnOvm2Qz85VdczlOf+jTOHg585I8+hCBkM1aLllIK" +
            "H/7jT/IfP/gXNKuLiFPCCaQ0q1BRXOsZTp2uNzWbyrqJipgwe5a6E6zZMuDDnNT3tXqqpLFHRAlhRTy1X9tPHGU7VvUwbevKPNfoKg/7F" +
            "UxnjeZvvukVANz38Bk++T9u4Ut/eTv7P7yX5z//efyX9/wnnnXt03j1jftc/vinsLNoaReBnWXHatGyWnWslg2LtqEJineurquBFPO8Jo" +
            "BcKtRaKfUplvz/vWhT5UrJ9aWbXDIxRoZx4vCw53C94ezBmilmNpuecZrmh1YdYpmRz1991ZWcPrtl6Hve9e46H0FbLrz0Spxz7O7u8t/" +
            "/5POE3e+hTup0GzRdxzT0+MXyvHgU9XW1YHXrW6G0vvEg4qr6LYU0DrMvr+GGicwpYp6VsZGmDcxZQpX4CRElpxFxTQUN19V5FfAH28TZ" +
            "9Zr7fnAPL7rhZVzzzBdwdJm54YYXs+knusWCX7jpeh535RNpgqdpGvZ2F+ysWnZ3V+wsO7pG8U5xIqgKxo9v+JwrrK88WQ2+rVbix6mhY" +
            "SXPlcukVBiGkYN1z5mzB5w6c8i2H9hues6Z/HMvtp37+X/8lTsPhRrM6wAAAABJRU5ErkJggg==";

        public static string _ENCODED_ELEGANT_BLUE_IMAGE_EMPTY
        {

            get { return ENCODED_ELEGANT_BLUE_IMAGE_EMPTY; }
        }

    }
}
