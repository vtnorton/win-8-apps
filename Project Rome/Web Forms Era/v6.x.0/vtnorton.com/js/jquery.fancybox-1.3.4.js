﻿(function (a) { var n, u, v, e, C, m, D, h, z, A, r = 0, d = {}, p = [], q = 0, c = {}, k = [], F = null, w = new Image, H = /\.(jpg|gif|png|bmp|jpeg)(.*)?$/i, S = /[^\.]\.(swf)\s*$/i, I, J = 1, y = 0, x = "", t, g, l = !1, B = a.extend(a("<div/>")[0], { prop: 0 }), K = a.browser.msie && 7 > a.browser.version && !window.XMLHttpRequest, L = function () { u.hide(); w.onerror = w.onload = null; F && F.abort(); n.empty() }, M = function () { !1 === d.onError(p, r, d) ? (u.hide(), l = !1) : (d.titleShow = !1, d.width = "auto", d.height = "auto", n.html('<p id="fancybox-error">The requested content cannot be loaded.<br />Please try again later.</p>'), E()) }, G = function () { var b = p[r], f, c, e, g, k, h; L(); d = a.extend({}, a.fn.fancybox.defaults, "undefined" == typeof a(b).data("fancybox") ? d : a(b).data("fancybox")); h = d.onStart(p, r, d); if (!1 === h) l = !1; else { "object" == typeof h && (d = a.extend(d, h)); e = d.title || (b.nodeName ? a(b).attr("title") : b.title) || ""; b.nodeName && !d.orig && (d.orig = a(b).children("img:first").length ? a(b).children("img:first") : a(b)); "" === e && d.orig && d.titleFromAlt && (e = d.orig.attr("alt")); f = d.href || (b.nodeName ? a(b).attr("href") : b.href) || null; if (/^(?:javascript)/i.test(f) || "#" == f) f = null; d.type ? (c = d.type, f || (f = d.content)) : d.content ? c = "html" : f && (c = f.match(H) ? "image" : f.match(S) ? "swf" : a(b).hasClass("iframe") ? "iframe" : 0 === f.indexOf("#") ? "inline" : "ajax"); if (c) switch ("inline" == c && (b = f.substr(f.indexOf("#")), c = 0 < a(b).length ? "inline" : "ajax"), d.type = c, d.href = f, d.title = e, d.autoDimensions && ("html" == d.type || "inline" == d.type || "ajax" == d.type ? (d.width = "auto", d.height = "auto") : d.autoDimensions = !1), d.modal && (d.overlayShow = !0, d.hideOnOverlayClick = !1, d.hideOnContentClick = !1, d.enableEscapeButton = !1, d.showCloseButton = !1), d.padding = parseInt(d.padding, 10), d.margin = parseInt(d.margin, 10), n.css("padding", d.padding + d.margin), a(".fancybox-inline-tmp").unbind("fancybox-cancel").bind("fancybox-change", function () { a(this).replaceWith(m.children()) }), c) { case "html": n.html(d.content); E(); break; case "inline": if (!0 === a(b).parent().is("#fancybox-content")) { l = !1; break } a('<div class="fancybox-inline-tmp" />').hide().insertBefore(a(b)).bind("fancybox-cleanup", function () { a(this).replaceWith(m.children()) }).bind("fancybox-cancel", function () { a(this).replaceWith(n.children()) }); a(b).appendTo(n); E(); break; case "image": l = !1; a.fancybox.showActivity(); w = new Image; w.onerror = function () { M() }; w.onload = function () { l = !0; w.onerror = w.onload = null; d.width = w.width; d.height = w.height; a("<img />").attr({ id: "fancybox-img", src: w.src, alt: d.title }).appendTo(n); N() }; w.src = f; break; case "swf": d.scrolling = "no"; g = '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="' + d.width + '" height="' + d.height + '"><param name="movie" value="' + f + '"></param>'; k = ""; a.each(d.swf, function (b, a) { g += '<param name="' + b + '" value="' + a + '"></param>'; k += " " + b + '="' + a + '"' }); g += '<embed src="' + f + '" type="application/x-shockwave-flash" width="' + d.width + '" height="' + d.height + '"' + k + "></embed></object>"; n.html(g); E(); break; case "ajax": l = !1; a.fancybox.showActivity(); d.ajax.win = d.ajax.success; F = a.ajax(a.extend({}, d.ajax, { url: f, data: d.ajax.data || {}, error: function (b, a, f) { 0 < b.status && M() }, success: function (b, a, c) { if (200 == ("object" == typeof c ? c : F).status) { if ("function" == typeof d.ajax.win) { h = d.ajax.win(f, b, a, c); if (!1 === h) { u.hide(); return } if ("string" == typeof h || "object" == typeof h) b = h } n.html(b); E() } } })); break; case "iframe": N() } else M() } }, E = function () { var b = d.width, c = d.height, b = -1 < b.toString().indexOf("%") ? parseInt((a(window).width() - 2 * d.margin) * parseFloat(b) / 100, 10) + "px" : "auto" == b ? "auto" : b + "px", c = -1 < c.toString().indexOf("%") ? parseInt((a(window).height() - 2 * d.margin) * parseFloat(c) / 100, 10) + "px" : "auto" == c ? "auto" : c + "px"; n.wrapInner('<div style="width:' + b + ";height:" + c + ";overflow: " + ("auto" == d.scrolling ? "auto" : "yes" == d.scrolling ? "scroll" : "hidden") + ';position:relative;"></div>'); d.width = n.width(); d.height = n.height(); N() }, N = function () { var b, f; u.hide(); if (e.is(":visible") && !1 === c.onCleanup(k, q, c)) a.event.trigger("fancybox-cancel"), l = !1; else { l = !0; a(m.add(v)).unbind(); a(window).unbind("resize.fb scroll.fb"); a(document).unbind("keydown.fb"); e.is(":visible") && "outside" !== c.titlePosition && e.css("height", e.height()); k = p; q = r; c = d; if (c.overlayShow) { if (v.css({ "background-color": c.overlayColor, opacity: c.overlayOpacity, cursor: c.hideOnOverlayClick ? "pointer" : "auto", height: a(document).height() }), !v.is(":visible")) { if (K) a("select:not(#fancybox-tmp select)").filter(function () { return "hidden" !== this.style.visibility }).css({ visibility: "hidden" }).one("fancybox-cleanup", function () { this.style.visibility = "inherit" }); v.show() } } else v.hide(); g = T(); x = c.title || ""; y = 0; h.empty().removeAttr("style").removeClass(); if (!1 !== c.titleShow && (x = a.isFunction(c.titleFormat) ? c.titleFormat(x, k, q, c) : x && x.length ? "float" == c.titlePosition ? '<table id="fancybox-title-float-wrap" cellpadding="0" cellspacing="0"><tr><td id="fancybox-title-float-left"></td><td id="fancybox-title-float-main">' + x + '</td><td id="fancybox-title-float-right"></td></tr></table>' : '<div id="fancybox-title-' + c.titlePosition + '">' + x + "</div>" : !1) && "" !== x) switch (h.addClass("fancybox-title-" + c.titlePosition).html(x).appendTo("body").show(), c.titlePosition) { case "inside": h.css({ width: g.width - 2 * c.padding, marginLeft: c.padding, marginRight: c.padding }); y = h.outerHeight(!0); h.appendTo(C); g.height += y; break; case "over": h.css({ marginLeft: c.padding, width: g.width - 2 * c.padding, bottom: c.padding }).appendTo(C); break; case "float": h.css("left", -1 * parseInt((h.width() - g.width - 40) / 2, 10)).appendTo(e); break; default: h.css({ width: g.width - 2 * c.padding, paddingLeft: c.padding, paddingRight: c.padding }).appendTo(e) } h.hide(); e.is(":visible") ? (a(D.add(z).add(A)).hide(), b = e.position(), t = { top: b.top, left: b.left, width: e.width(), height: e.height() }, f = t.width == g.width && t.height == g.height, m.fadeTo(c.changeFade, .3, function () { var b = function () { m.html(n.contents()).fadeTo(c.changeFade, 1, O) }; a.event.trigger("fancybox-change"); m.empty().removeAttr("filter").css({ "border-width": c.padding, width: g.width - 2 * c.padding, height: d.autoDimensions ? "auto" : g.height - y - 2 * c.padding }); f ? b() : (B.prop = 0, a(B).animate({ prop: 1 }, { duration: c.changeSpeed, easing: c.easingChange, step: P, complete: b })) })) : (e.removeAttr("style"), m.css("border-width", c.padding), "elastic" == c.transitionIn ? (t = R(), m.html(n.contents()), e.show(), c.opacity && (g.opacity = 0), B.prop = 0, a(B).animate({ prop: 1 }, { duration: c.speedIn, easing: c.easingIn, step: P, complete: O })) : ("inside" == c.titlePosition && 0 < y && h.show(), m.css({ width: g.width - 2 * c.padding, height: d.autoDimensions ? "auto" : g.height - y - 2 * c.padding }).html(n.contents()), e.css(g).fadeIn("none" == c.transitionIn ? 0 : c.speedIn, O))) } }, U = function () { (c.enableEscapeButton || c.enableKeyboardNav) && a(document).bind("keydown.fb", function (b) { 27 == b.keyCode && c.enableEscapeButton ? (b.preventDefault(), a.fancybox.close()) : 37 != b.keyCode && 39 != b.keyCode || !c.enableKeyboardNav || "INPUT" === b.target.tagName || "TEXTAREA" === b.target.tagName || "SELECT" === b.target.tagName || (b.preventDefault(), a.fancybox[37 == b.keyCode ? "prev" : "next"]()) }); c.showNavArrows ? ((c.cyclic && 1 < k.length || 0 !== q) && z.show(), (c.cyclic && 1 < k.length || q != k.length - 1) && A.show()) : (z.hide(), A.hide()) }, O = function () { a.support.opacity || (m.get(0).style.removeAttribute("filter"), e.get(0).style.removeAttribute("filter")); d.autoDimensions && m.css("height", "auto"); e.css("height", "auto"); x && x.length && h.show(); c.showCloseButton && D.show(); U(); c.hideOnContentClick && m.bind("click", a.fancybox.close); c.hideOnOverlayClick && v.bind("click", a.fancybox.close); a(window).bind("resize.fb", a.fancybox.resize); c.centerOnScroll && a(window).bind("scroll.fb", a.fancybox.center); "iframe" == c.type && a('<iframe id="fancybox-frame" name="fancybox-frame' + (new Date).getTime() + '" frameborder="0" hspace="0" ' + (a.browser.msie ? 'allowtransparency="true""' : "") + ' scrolling="' + d.scrolling + '" src="' + c.href + '"></iframe>').appendTo(m); e.show(); l = !1; a.fancybox.center(); c.onComplete(k, q, c); var b, f; k.length - 1 > q && (b = k[q + 1].href, "undefined" !== typeof b && b.match(H) && (f = new Image, f.src = b)); 0 < q && (b = k[q - 1].href, "undefined" !== typeof b && b.match(H) && (f = new Image, f.src = b)) }, P = function (b) { var a = { width: parseInt(t.width + (g.width - t.width) * b, 10), height: parseInt(t.height + (g.height - t.height) * b, 10), top: parseInt(t.top + (g.top - t.top) * b, 10), left: parseInt(t.left + (g.left - t.left) * b, 10) }; "undefined" !== typeof g.opacity && (a.opacity = .5 > b ? .5 : b); e.css(a); m.css({ width: a.width - 2 * c.padding, height: a.height - y * b - 2 * c.padding }) }, Q = function () { return [a(window).width() - 2 * c.margin, a(window).height() - 2 * c.margin, a(document).scrollLeft() + c.margin, a(document).scrollTop() + c.margin] }, T = function () { var b = Q(), a = {}, e = c.autoScale, g = 2 * c.padding; -1 < c.width.toString().indexOf("%") ? a.width = parseInt(b[0] * parseFloat(c.width) / 100, 10) : a.width = c.width + g; -1 < c.height.toString().indexOf("%") ? a.height = parseInt(b[1] * parseFloat(c.height) / 100, 10) : a.height = c.height + g; e && (a.width > b[0] || a.height > b[1]) && ("image" == d.type || "swf" == d.type ? (e = c.width / c.height, a.width > b[0] && (a.width = b[0], a.height = parseInt((a.width - g) / e + g, 10)), a.height > b[1] && (a.height = b[1], a.width = parseInt((a.height - g) * e + g, 10))) : (a.width = Math.min(a.width, b[0]), a.height = Math.min(a.height, b[1]))); a.top = parseInt(Math.max(b[3] - 20, b[3] + .5 * (b[1] - a.height - 40)), 10); a.left = parseInt(Math.max(b[2] - 20, b[2] + .5 * (b[0] - a.width - 40)), 10); return a }, R = function () { var b = d.orig ? a(d.orig) : !1, f = {}; b && b.length ? (f = b.offset(), f.top += parseInt(b.css("paddingTop"), 10) || 0, f.left += parseInt(b.css("paddingLeft"), 10) || 0, f.top += parseInt(b.css("border-top-width"), 10) || 0, f.left += parseInt(b.css("border-left-width"), 10) || 0, f.width = b.width(), f.height = b.height(), f = { width: f.width + 2 * c.padding, height: f.height + 2 * c.padding, top: f.top - c.padding - 20, left: f.left - c.padding - 20 }) : (b = Q(), f = { width: 2 * c.padding, height: 2 * c.padding, top: parseInt(b[3] + .5 * b[1], 10), left: parseInt(b[2] + .5 * b[0], 10) }); return f }, V = function () { u.is(":visible") ? (a("div", u).css("top", -40 * J + "px"), J = (J + 1) % 12) : clearInterval(I) }; a.fn.fancybox = function (b) { if (!a(this).length) return this; a(this).data("fancybox", a.extend({}, b, a.metadata ? a(this).metadata() : {})).unbind("click.fb").bind("click.fb", function (b) { b.preventDefault(); l || (l = !0, a(this).blur(), p = [], r = 0, (b = a(this).attr("rel") || "") && "" != b && "nofollow" !== b ? (p = a("a[rel=" + b + "], area[rel=" + b + "]"), r = p.index(this)) : p.push(this), G()) }); return this }; a.fancybox = function (b, c) { var d; if (!l) { l = !0; d = "undefined" !== typeof c ? c : {}; p = []; r = parseInt(d.index, 10) || 0; if (a.isArray(b)) { for (var e = 0, g = b.length; e < g; e++) "object" == typeof b[e] ? a(b[e]).data("fancybox", a.extend({}, d, b[e])) : b[e] = a({}).data("fancybox", a.extend({ content: b[e] }, d)); p = jQuery.merge(p, b) } else "object" == typeof b ? a(b).data("fancybox", a.extend({}, d, b)) : b = a({}).data("fancybox", a.extend({ content: b }, d)), p.push(b); if (r > p.length || 0 > r) r = 0; G() } }; a.fancybox.showActivity = function () { clearInterval(I); u.show(); I = setInterval(V, 66) }; a.fancybox.hideActivity = function () { u.hide() }; a.fancybox.next = function () { return a.fancybox.pos(q + 1) }; a.fancybox.prev = function () { return a.fancybox.pos(q - 1) }; a.fancybox.pos = function (a) { l || (a = parseInt(a), p = k, -1 < a && a < k.length ? (r = a, G()) : c.cyclic && 1 < k.length && (r = a >= k.length ? 0 : k.length - 1, G())) }; a.fancybox.cancel = function () { l || (l = !0, a.event.trigger("fancybox-cancel"), L(), d.onCancel(p, r, d), l = !1) }; a.fancybox.close = function () { function b() { v.fadeOut("fast"); h.empty().hide(); e.hide(); a.event.trigger("fancybox-cleanup"); m.empty(); c.onClosed(k, q, c); k = d = []; q = r = 0; c = d = {}; l = !1 } if (!l && !e.is(":hidden")) if (l = !0, c && !1 === c.onCleanup(k, q, c)) l = !1; else if (L(), a(D.add(z).add(A)).hide(), a(m.add(v)).unbind(), a(window).unbind("resize.fb scroll.fb"), a(document).unbind("keydown.fb"), m.find("iframe").attr("src", K && /^https/i.test(window.location.href || "") ? "javascript:void(false)" : "about:blank"), "inside" !== c.titlePosition && h.empty(), e.stop(), "elastic" == c.transitionOut) { t = R(); var f = e.position(); g = { top: f.top, left: f.left, width: e.width(), height: e.height() }; c.opacity && (g.opacity = 1); h.empty().hide(); B.prop = 1; a(B).animate({ prop: 0 }, { duration: c.speedOut, easing: c.easingOut, step: P, complete: b }) } else e.fadeOut("none" == c.transitionOut ? 0 : c.speedOut, b) }; a.fancybox.resize = function () { v.is(":visible") && v.css("height", a(document).height()); a.fancybox.center(!0) }; a.fancybox.center = function (a) { var d, g; l || (g = !0 === a ? 1 : 0, d = Q(), !g && (e.width() > d[0] || e.height() > d[1]) || e.stop().animate({ top: parseInt(Math.max(d[3] - 20, d[3] + .5 * (d[1] - m.height() - 40) - c.padding)), left: parseInt(Math.max(d[2] - 20, d[2] + .5 * (d[0] - m.width() - 40) - c.padding)) }, "number" == typeof a ? a : 200)) }; a.fancybox.init = function () { a("#fancybox-wrap").length || (a("body").append(n = a('<div id="fancybox-tmp"></div>'), u = a('<div id="fancybox-loading"><div></div></div>'), v = a('<div id="fancybox-overlay"></div>'), e = a('<div id="fancybox-wrap"></div>')), C = a('<div id="fancybox-outer"></div>').append('<div class="fancybox-bg" id="fancybox-bg-n"></div><div class="fancybox-bg" id="fancybox-bg-ne"></div><div class="fancybox-bg" id="fancybox-bg-e"></div><div class="fancybox-bg" id="fancybox-bg-se"></div><div class="fancybox-bg" id="fancybox-bg-s"></div><div class="fancybox-bg" id="fancybox-bg-sw"></div><div class="fancybox-bg" id="fancybox-bg-w"></div><div class="fancybox-bg" id="fancybox-bg-nw"></div>').appendTo(e), C.append(m = a('<div id="fancybox-content"></div>'), h = a('<div id="fancybox-title"></div>'), z = a('<a href="javascript:;" id="fancybox-left"><span class="fancy-ico" id="fancybox-left-ico"></span></a>'), D = a('<a id="fancybox-close"></a>'), A = a('<a href="javascript:;" id="fancybox-right"><span class="fancy-ico" id="fancybox-right-ico"></span></a>')), D.click(a.fancybox.close), u.click(a.fancybox.cancel), z.click(function (b) { b.preventDefault(); a.fancybox.prev() }), A.click(function (b) { b.preventDefault(); a.fancybox.next() }), a.fn.mousewheel && e.bind("mousewheel.fb", function (b, c) { if (l) b.preventDefault(); else if (0 == a(b.target).get(0).clientHeight || a(b.target).get(0).scrollHeight === a(b.target).get(0).clientHeight) b.preventDefault(), a.fancybox[0 < c ? "prev" : "next"]() }), a.support.opacity || e.addClass("fancybox-ie"), K && (u.addClass("fancybox-ie6"), e.addClass("fancybox-ie6"), a('<iframe id="fancybox-hide-sel-frame" src="' + (/^https/i.test(window.location.href || "") ? "javascript:void(false)" : "about:blank") + '" scrolling="no" border="0" frameborder="0" tabindex="-1"></iframe>').prependTo(C))) }; a.fn.fancybox.defaults = { padding: 10, margin: 40, opacity: !1, modal: !1, cyclic: !1, scrolling: "auto", width: 560, height: 340, autoScale: !0, autoDimensions: !0, centerOnScroll: !1, ajax: {}, swf: { wmode: "transparent" }, hideOnOverlayClick: !0, hideOnContentClick: !1, overlayShow: !0, overlayOpacity: .7, overlayColor: "#777", titleShow: !0, titlePosition: "float", titleFormat: null, titleFromAlt: !1, transitionIn: "fade", transitionOut: "fade", speedIn: 300, speedOut: 300, changeSpeed: 300, changeFade: 100, easingIn: "swing", easingOut: "swing", showCloseButton: !0, showNavArrows: !0, enableEscapeButton: !0, enableKeyboardNav: !0, onStart: function () { }, onCancel: function () { }, onComplete: function () { }, onCleanup: function () { }, onClosed: function () { }, onError: function () { } }; a(document).ready(function () { a.fancybox.init() }) })(jQuery);