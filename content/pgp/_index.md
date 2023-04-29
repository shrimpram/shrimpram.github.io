---
title: PGP
---

This page will be kept up to date with my latest PGP public key and have
instructions on how to download it.

### Details
- **Type**: PGPv4, rsa4096
- **Fingerprint**: EA88 EA07 26E9 6CBF 6365 3966 163B 16EE 76ED 24CE

### Getting My Key

#### From a public key server

```language-bash
gpg --keyserver hkps://keys.openpgp.org --recv-key 0x163B16EE76ED24CE
```

#### From my website

<!-- You can [download my public key]({{< relref "0x163B16EE76ED24CE.pub.asc" >}}) -->

```language-bash
curl -O https://shreerammodi.com/static/pgp/0x163B16EE76ED24CE.pub.asc
```

and then import it into GPG

```language-bash
gpg --import 0x163B16EE76ED24CE.pub.asc
```

