---
title: The 40% Colemak Planck
date: 2022-04-11
tags: ["tech"]
draft: false
description: "How I made my olkb planck keyboard"
---

A few years ago, after deciding to build my own mechanical keyboard and
shopping around for a while attempting the near impossible task of
choosing one build from the infinite combinations of parts available, I
finally chose to build an [OLKB
Planck](https://olkb.com/collections/planck). This post explains the
thoughts that went into building it as well as the parts used and
layouts.

## The Motive

One of the main reasons I went the full custom route was to better allow
customization of my keyboard's layout. I had been learning and slowly
transitioning to using [Colemak](https://colemak.com/) full time, and
having the ability to customize my keyboard down to its layout would
better enable me to use Colemak without needing to install third-party
keyboard layouts. I also used it as a tool to speed up my learning, as
forcing myself to use Colemak without the option to easily switch
layouts back to QWERTY would build muscle memory faster and help me get
back to my normal typing speed.

The other main reason for choosing this particular style of keyboard
also had to do with the layout. Being able to use a custom layout
enabled me to fully utilize things such as layers to make my keyboard
more ergonomic. The idea behind layers is that rather than moving your
fingers physically across the keyboard to reach keys such as arrows,
f-keys, media keys, etc. you hold down modifiers to bring those keys to
you. This relieves a lot of the strain on your fingers when typing as
they don't have to move around as much to type the same characters.
["Tiny Keyboards: An Explanation"](https://youtu.be/AKGXZ1ReU54) is a
great video that explains the logic behind this, and the tiny keyboard
shown in the video is also a 40% ortholinear, just like the Planck.

## The Parts

(A quick disclaimer that I'm not affiliated with any of the companies
listed below nor is this an endorsement of their products but simply a
blog post about my personal keyboard.)

With that out of the way this build was based mainly around the EOTW
Planck, and as such uses parts from that version. However, at the time I
was building it the PCB and plates compatible with the EOTW bottom plate
were out of stock on the [OLKB website](https://olkb.com) so I had to
buy them from [Drop](https://drop.com). I went with an XDA keycap set
since I really liked how low they sat on the keyboard and thought they
would contribute to a clean, minimal look for the build especially since
it wouldn't have a case, just a bottom plate.

- [EOTW Bottom Plate from
  OLKB](https://olkb.com/products/planck-eotw-bottom-plate)
- [Planck kit from
  Drop](https://drop.com/buy/planck-mechanical-keyboard)
- [Drop + Mito XDA Canvas
  keycaps](https://drop.com/buy/drop-mito-xda-canvas-keycap-set)
- [NovelKeys Cream
  switches](https://novelkeys.com/products/nk_-cream-series)

As for other miscellaneous stuff I filmed and lubed the switches myself,
which for my first time ever building a keyboard let alone modding
switches turned out better than expected.

- [0.125mm TX Switch
  Films](https://www.ashkeebs.com/product/tx-switch-films/)
- [Krytox
  205g0](https://www.ashkeebs.com/product/205g0-switch-lubricant/)

## The Layout

A json file of my keymap to use with [QMK
Configurator](https://config.qmk.fm) can be found in my [dotfiles
repo](https://github.com/shrimpram/dotfiles) on Github [(raw
file)](https://raw.githubusercontent.com/Shrimpram/dotfiles/master/colemak_planck.json).

### Layer 0

{{< figure src="../../images/olkb-planck/layer-0.png" alt="tsrtsr" caption="Layer 0" >}}
{{< figure src="elephant.jpg" title=">An elephant at sunset" >}}

This is the default Colemak layer. The bottom row has modifier keys as
well as the different layer keys to change between layers. There is a
backspace where caps lock is normally located since the former is much
more useful than the latter and I have caps lock on another layer.
Another way QMK helps me save space is with the two shift keys.
Normally, when pressed and released these two keys act as the key code
in parentheses. The left shift is an escape key and the right shift is a
slash key. However, when held while pressing another key, they act as
shift keys and I can type uppercase letters.

### Layer 1

![layer 1](../static/olkb-planck/layer-1.png)

This is a QWERTY layer I have just in case, which I access by pressing
`MO(4)` and then the spacebar. The only difference is in the alphas
since all the modifiers and other keys have the `KC_TRNS` code which
makes them transparent to QMK so they inherit the keycode of the next
layer below them.

### Layer 2

![layer 2](../static/olkb-planck/layer-2.png)

This is a function and numpad layer. I opted for a numpad instead of a
number row since at the time I was taking an accounting class and having
a numpad allowed me to work much faster than a number row. The layout is
fairly standard, with math operators next to the numbers as well as two
enter keys since I couldn't figure out what else to place there and it's
much easier to hit with the palm of my hand while keeping my fingers on
the numpad.

### Layer 3

![layer 3](../static/olkb-planck/layer-3.png)

This layer is an extension of layer 2 with symbols instead of
numbers/f-keys. It also has some other miscellaneous useful keys such as
delete, caps lock, and the grave/tilde key. These other miscellaneous
keys fit well here since I access this layer with `TT(3)` which is right
next to the spacebar.

### Layer 4

![layer 4](../static/olkb-planck/layer-4.png)

This layer has all my media controls as well as the toggle between
Colemak and QWERTY.
