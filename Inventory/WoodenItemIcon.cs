using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class WoodenItemIcon
    {
        private static String ENCODED_WOODEN_IMAGE_NULL = 
			"data:image/png;base64,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"
			+ "VHmtu3/h/xQDKldybtKwAAAABJRU5ErkJggg==";
	
        public static string _ENCODED_WOODEN_IMAGE_NULL
        {

            get { return ENCODED_WOODEN_IMAGE_NULL; }
        }

        private static String ENCODED_WOODEN_IMAGE_EMPTY =
            " data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAAAXNSR0IArs4c6QAAAAZiS0dEAFEAPwAYwGt" +
            "n/wAAAAlwSFlzAAALEwAACxMBAJqcGAAAAAd0SU1FB+IDCxMDOW2xKxoAAAAdaVRYdENvbW1lbnQAAAAAAENyZWF0ZWQgd2l0aCBHSU1QZ" +
            "C5lBwAADB9JREFUaN6NmuuSXFcNhT9p7+7p8fgSOyGOIUkBRf5B8Qg8A89OqqiiXAFygTjEiW0cz3SfsyV+bO3LmRk7dHlqxt2nT29JS0t" +
            "LUsuf//SRc8tDBVISznbKfqfkJKgIIsLbrj/bC3cOmTsHZb9L6O2X9oeZsxTn8mrlp6NxPBqn1TgtznEpLItRDJyff2SA3//6d7ceTFXI" +
            "qR7qfJ857DM5KUmVlBL7wznn9+7z4NGHPPzwCY8++pj7jz5gf7iDu+Fm9V4pgwi4QXOGO+u6cHzzEy++f8bzf33JD99+w6sfv+f45jVrK" +
            "ZRiLGvh6lS4PC1cHlfWsjVLBP7y96fVEIDP//H0pjEK+6yc7RP7LCR9R0QUDnvl3nnm/CyRsyDCjevdx0EcKMW5OhZ+uiocTzUaazFW84" +
            "iIYQbFHfPqC/cRpT/+9rMRkfb4w29/wye/uCAlwRHoP+Au8WYF0fobEM2IJjTV51UctwKUGhFfcXPwgrvXe5hhXu8tkpD7GU05jHZwxyn" +
            "1t8fpEVQBUYo7X3/7kr88/Rs5KSLXDPnk8T0++/gBu12qJseBHZ88IWFMAhFUE6KZlDKiguC4r3hZcSv1b7c4XzXEjXozkWp82oFUQ6op" +
            "BaEZEMYIqCiiylIMAf76d+H8sCOrbA3JSdjvEvtdBhwRwX0Y0iMkCURxtEZDE5JSvFrqtSqYCW4KLgGpiC5So0Q1RDSPPKq+xyMy4EgzR" +
            "BVRIa2FXaokdP/ePXZZt4bQvD1BqkZbEHUGvL3/iJf6p4GL4N4g1Q7SIFnzy9vbpcK1mdZyR+J5IjZgdPqTcS5wdkl59P77lVVvUMAtFB" +
            "skg0gzxoYxLj0HKhS9G1EPFAkvdCPq/TwMEHCJ54Vwfj9vi442I6YXcxYef/wpOcltEZHpQM19zQkC4lNASs0ZcVwUkflabnhRiGR373C" +
            "TuFkDXo2aBBIsIunh4O1p91n58Fefss83DNENS42w30a4E426BRBkglBEtxsTB2tJ714j06LkYao3OIPoiFSLKlin38NO+ODJJxz2SlYZG" +
            "VEPXJmqenfAo3rNp8RlGOjg6sMIb96T+Cf1AAhIlOqAaSUMmSIhoMOJIxrGxnJ3Lu7suLj/HhfnmZyTkJKwy7cVujmcacbLhDrHReKwEdH" +
            "ItY7WayH1cFDLu4raWQKN3BKsM526RVTrc+cHJeXMxXkinx8q3R72qeP1hrqRwTTtJemI13ithVYGFOIaD2Pa4eOJOG9FgIoiaIdQz5Fm" +
            "jDuOBT0a7sY+K2ZGzopeHDLn+yorBhNt86Bh2jdYasXKwsMO5uNln+ib6fDOhtYRqbkgW0aq4fLOboQx9TN8c28VyHfPE4d94s5BpzfdAFj" +
            "jm2upPhktPhhKdaLKbd3xibZrgVNEtEqVFJW9kUHQuImNwui2caqmVKn47nmF1vkhTR9jtQgGljxgIL41yM07g3R2knqwLRNM9bGxm7aqnl" +
            "DVantnNgu9Nu4xPnnWgdTPAvLZPnF2tudsl8aHRci9e1wm5SrhkS0JO4pKQlTDGA+t1WA4y9bII00RkfpZ3eNWcFvH0UV77lW3apAPWFmj" +
            "OCbh/OIuSQc0nVptG1J8U5LpjGJRQwjGQbTqLpHei4xaM8peTegUB9RAYagBK2Cl/m4koj7omRRUvG0LMsDdBw9Rlc5s7jUBvSdjkxxbAr" +
            "iuCGSS94M4bLzPhwRqkWgZ61aZCCuYWYWtgHYYaaDENlpQNQ1DHn74pOspn/sNnc8ah+qFrNUJDbrVmuSybaK6NvPJ6PaeNBiqis2Cu2GR" +
            "e7WMCgmFiHTPsWBFDShlgA+efBrQSIjuQHagGowYsoIIp/lUWjy8GnnBbUXVRkMlrWsMZwUl17Z4xUo1iJ6nlQwk5drACaGsR0SsVAhnE" +
            "Xj4+JfVmZJAE2iuSVuPioiHsrCpNgcsgka3NniHiodAHEqhJXhTuxY50aLCpA40nFt/ep5ORbvlYga4uPdeRGSS3VMNIaqzt8LWa4f2iEg" +
            "kba3AQeMTu1X4paqjZIhNN8NpTBWQktFwSTRx12uYN+UTN1MAzXmSRrcAxIeiqDnSklZrUWsGtR7D4oDmcbgqZUQ1klP7tbW3r9e03PAw" +
            "Aknb+18HrXsviCoinYsHbCblPRe29n9p9Cxj8NAhVQLnU26EERWyeUhyL1gJo33uSyJfU0B9li2T+ijFWU9HzDz6kab5e3NjuOuIgE2taO" +
            "unNaAiTfV6OMTAHGszLa3Goql7r00gLOY7PlXtyn71WtWEBmT9epMHXJ2M1y9+YClhiEwjwVH7PKqt0Tpv631o85ojYURNujC6+TW82SA4" +
            "vNnGPOM3U1usAVsRjVoy16SBkKuT8fzbrzieLAxpyaRThZUqGZonfFatPdRTg9QSt7WnWiu3qKIpdYaSqfh145kJodWjyNUgD8Emo6thx5" +
            "Px/N9fc3kMQ6wUJkUV8JBw0lSZBbBt91evJbxVsNIiXOdVEiMcmhFeOvyc5gTZKmdRVKNT9BGN1jq0x1qcl98/47QY2d2xFjKpkBpDhJb4" +
            "vm1VfC50OhjHBtZVE5pysFRoaiu9KfJJFcs0rhHRCq0Yu/hkxKhL9GR//eoFp9W2w4dWpKS3p9YHZb2baAOE2dReWwLbrYBprnK9FzrfwK" +
            "PnCYPORyGMTjGGFXN+NZSYO8fLN5Ti5NkjrTntIXQHm/+uFlS+b9CqzFXRkfBQwCqpz6KEBtMtffb8iBbZWxWTeUDXnOcxP7N+CweWZcEdc" +
            "rFqlc3Fo3+mbZLM42Y1KAKulRRoajYKWMq9S5Q+fbHpYKMLZJowjpWD3FDZoyuU0agZLKth7uTLY+G/P37PsgyF2liiHb7VBLdKwT03GHKC" +
            "mMpLi8isv6bx0WDBSS6I1LHQjUkkPRK9YJpjrSB6XQitxclvLgvPn33Dm6sCyLSDmCLgNQo2tbatZ+kUG3mh2rpERrELaNTo2IysSPYxJ/X" +
            "elEmPZJsluzVj6jRmXY3jsrKsRr48Gi//84zXVwVv8joaGe8jHN1I8VqlUijTITtk5v+Ag1DCM+XafCuSvHeNQ1006ElbZ0iquaO1xEuohWV" +
            "1Lo8rp9Vrjrz84TuWxarEpipULx6JHAMBFcSoCxqNOVQ3Qrsmkt6EeSeOmzMYbh0GdroRajFueeP01tjdYxSWWa2u5tbV0GLO5X9f1d2cVG3" +
            "FvMuIbrB3hb3PTn1PMoSddPZpo9XxM+0T/o/HGHa3HKKzWot5mUZd2R2W41V80DT6FJs8NQ2oNUX/MSYg7Ud1TN0R346EePcgfPQRLQJjTi" +
            "b4aPQcUANNNWfibbmYUcpKaQkVc1X3eZjmfRUn09JmNpQb/5t0kfOWwd88TQ4j+jM6GsKWbzJNtSJnm97VZa2b03X1aa7q03hm1kQ+2lDmU" +
            "f8tR7yx3brNjG00pHk82lkRNmSweVv3QnSIx1M14rgajXtbDZkX+zV5A6dNQtywQuZJDT+76p+Zijk1fWx4OwaaahFu85+eVufytHBaDGflx" +
            "uKDoa36/oJ5/C9vxb/7uwxgNNXz/Np9M9XcjJD7vmSsI1qksjlcHleK0ffb3pc52/ltB61cH1Jz7bp54v6ucIx1WxtS162fx4S+bbK2Hydj" +
            "hN6dobVlXPtUY9ufb5az00RR3gItNh/x1nIxRaVfLYz1RFuftL/FJxJwbvvyRQZYYshVirEspRY+HC9VZ5X4/ockJWGIlc0uo9OwapcbYga9" +
            "qkfn6KW2yzOJGCBrtP2GqEUzNiYn0pvnipJ1Ndb40oDZNPttWP7q2Svc6/7a6rwFM4vdioDuSHlXRzUTvrsxc2Xvkj3WA62p2jBgbLr7diu6S" +
            "UmhpG+rOc5aCt9897ILxxvfRfn8i6d8/sXPV93YV5KTsst1/5iTss/CLr6Ec7ZTcv8izmYz14vn29jbw9Onxbk8FS6vCqfFWZbCWuC4rBxX" +
            "vwmtt33V6V2G5KQcdvWrT4d9Yr9LpGkU2rZJ+8MdLu494MEHj3n4+Je8/9HH3H3wiN3ZAYv9iYiQUo4pfInvuChlXfnp1Qu+++af/OufX/D" +
            "t11/y/PkPvH79hqvjqW/6AORtXzz7fx4qkLNyloWzvXLYJ87PlMNZXeftct0YM2212orl5xSXe83dq6Px5li4OhqnpVAKnNbC8eQsq9G+vv" +
            "U/GDyDy4je67oAAAAASUVORK5CYII=";

        public static string _ENCODED_WOODEN_IMAGE_EMPTY
        {

            get { return ENCODED_WOODEN_IMAGE_EMPTY; }
        }
    }
}
