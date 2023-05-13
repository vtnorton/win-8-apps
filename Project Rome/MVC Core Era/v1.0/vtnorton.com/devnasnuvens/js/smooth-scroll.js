window.smoothScroll = function (e, t, n) { "use strict"; var a = { speed: 500, easing: "easeInOutCubic", updateURL: !1, callbackBefore: function () { }, callbackAfter: function () { } }, r = function (e, t) { for (var n in t) e[n] = t[n]; return e }, u = function (e, t) { return "easeInQuad" == e ? t * t : "easeOutQuad" == e ? t * (2 - t) : "easeInOutQuad" == e ? .5 > t ? 2 * t * t : -1 + (4 - 2 * t) * t : "easeInCubic" == e ? t * t * t : "easeOutCubic" == e ? --t * t * t + 1 : "easeInOutCubic" == e ? .5 > t ? 4 * t * t * t : (t - 1) * (2 * t - 2) * (2 * t - 2) + 1 : "easeInQuart" == e ? t * t * t * t : "easeOutQuart" == e ? 1 - --t * t * t * t : "easeInOutQuart" == e ? .5 > t ? 8 * t * t * t * t : 1 - 8 * --t * t * t * t : "easeInQuint" == e ? t * t * t * t * t : "easeOutQuint" == e ? 1 + --t * t * t * t * t : "easeInOutQuint" == e ? .5 > t ? 16 * t * t * t * t * t : 1 + 16 * --t * t * t * t * t : t }, o = function (e, t) { var n = 0; if (e.offsetParent) do n += e.offsetTop, e = e.offsetParent; while (e); return n -= t, n >= 0 ? n : 0 }, i = function (e) { if (null === e || e === n) return {}; var t = {}; return e = e.split(";"), e.forEach(function (e) { e = e.trim(), "" !== e && (e = e.split(":"), t[e[0]] = e[1].trim()) }), t }, c = function (e, t) { t !== !0 && "true" !== t || !history.pushState || history.pushState({ pos: e.id }, "", e) }, l = function (n, l, s, f) { s = r(a, s || {}); var d, p, h, v = i(n ? n.getAttribute("data-options") : null), b = v.speed || s.speed, g = v.easing || s.easing, y = v.updateURL || s.updateURL, I = t.querySelector("[data-scroll-header]"), O = null === I ? 0 : I.offsetHeight + I.offsetTop, Q = e.pageYOffset, A = o(t.querySelector(l), O), S = A - Q, m = 0; n && "A" === n.tagName && f && f.preventDefault(), c(l, y); var k = function () { var a = e.pageYOffset; (h == A || a == A || e.innerHeight + a >= t.body.scrollHeight) && (clearInterval(d), s.callbackAfter(n, l)) }, w = function () { m += 16, p = m / b, p = p > 1 ? 1 : p, h = Q + S * u(g, p), e.scrollTo(0, Math.floor(h)), k(h, A, d) }, E = function () { s.callbackBefore(n, l), d = setInterval(w, 16) }; E() }, s = function (n) { if ("querySelector" in t && "addEventListener" in e && Array.prototype.forEach) { n = r(a, n || {}); var u = t.querySelectorAll("[data-scroll]"); Array.prototype.forEach.call(u, function (e, t) { e.addEventListener("click", l.bind(null, e, e.getAttribute("href"), n), !1) }) } }; return { init: s, animateScroll: l } }(window, document);