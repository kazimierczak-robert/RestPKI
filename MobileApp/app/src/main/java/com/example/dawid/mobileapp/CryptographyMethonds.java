package com.example.dawid.mobileapp;

import android.util.Base64;
import android.util.Log;

import java.io.BufferedReader;
import java.io.StringReader;
import java.security.Key;
import java.security.KeyFactory;
import java.security.PublicKey;
import java.security.spec.KeySpec;
import java.security.spec.PKCS8EncodedKeySpec;
import java.security.spec.X509EncodedKeySpec;

import javax.crypto.Cipher;

/**
 * Created by Dawid on 17.12.2017.
 */

public class CryptographyMethonds {
    public static String Szyfowanie(String dataToEncrypt) throws Exception {

        java.security.cert.X509Certificate certy = testCzasu.convertToX509Cert(GlobalValue.getUserSend().getCert());

        PublicKey pk = certy.getPublicKey();
        byte[] publicKeyBytes1 = pk.getEncoded();
        String publicKeyBytesBase641 = new String(Base64.encode(publicKeyBytes1, Base64.DEFAULT));
        String encrypted1 = encryptRSAToString(dataToEncrypt, publicKeyBytesBase641);
        return  encrypted1;

    }

    public static String SzyfowanieCopy(String dataToEncrypt) throws Exception {

        java.security.cert.X509Certificate certy = testCzasu.convertToX509Cert(GlobalValue.getPublicCertificateGlobal());

        PublicKey pk = certy.getPublicKey();
        byte[] publicKeyBytes1 = pk.getEncoded();
        String publicKeyBytesBase641 = new String(Base64.encode(publicKeyBytes1, Base64.DEFAULT));
        String encrypted1 = encryptRSAToString(dataToEncrypt, publicKeyBytesBase641);
        return  encrypted1;

    }

    public static String Odszyfrowanie(String dataToDecrypt, String IDCert) throws Exception {

        String privateK = "";
        for (PrivateKeyObject x: GlobalValue.getPrivateKeysList())
        {
            if(IDCert.equals(x.getID())) {
                privateK = x.getCertyficate();
            Log.d("znalazlo", "tak");
            }
        }
        java.security.PrivateKey privateKey = getRSAPrivateKeyFromString(privateK);
        byte[] privateKeyBytes = privateKey.getEncoded();
        String privateKeyBytesBase64 = new String(Base64.encode(privateKeyBytes, Base64.DEFAULT));
        String decrypted = decryptRSAToString(dataToDecrypt, privateKeyBytesBase64);
        return  decrypted;
    }
    public static String encryptRSAToString(String clearText, String publicKey) {
        String encryptedBase64 = "";
        try {
            KeyFactory keyFac = KeyFactory.getInstance("RSA");
            KeySpec keySpec = new X509EncodedKeySpec(Base64.decode(publicKey.trim().getBytes(), Base64.DEFAULT));
            Key key = keyFac.generatePublic(keySpec);

            // get an RSA cipher object and print the provider
            final Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
            // encrypt the plain text using the public key
            cipher.init(Cipher.ENCRYPT_MODE, key);

            byte[] encryptedBytes = cipher.doFinal(clearText.getBytes("UTF-8"));
            encryptedBase64 = new String(Base64.encode(encryptedBytes, Base64.DEFAULT));
        } catch (Exception e) {
            e.printStackTrace();
        }

        return encryptedBase64.replaceAll("(\\r|\\n)", "");
    }

    public static String decryptRSAToString(String encryptedBase64, String privateKey) {

        String decryptedString = "";
        try {
            KeyFactory keyFac = KeyFactory.getInstance("RSA");
            KeySpec keySpec = new PKCS8EncodedKeySpec(Base64.decode(privateKey.trim().getBytes(), Base64.DEFAULT));
            Key key = keyFac.generatePrivate(keySpec);

            // get an RSA cipher object and print the provider
            final Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1Padding");
            // encrypt the plain text using the public key
            cipher.init(Cipher.DECRYPT_MODE, key);

            byte[] encryptedBytes = Base64.decode(encryptedBase64, Base64.DEFAULT);
            byte[] decryptedBytes = cipher.doFinal(encryptedBytes);
            decryptedString = new String(decryptedBytes);
        } catch (Exception e) {
            e.printStackTrace();
        }

        return decryptedString;
    }

    private static PublicKey getRSAPublicKeyFromString() throws Exception{
        String public_key = GlobalValue.getPublicKeyGlobal();
        public_key = public_key.replace("-----BEGIN PUBLIC KEY-----", "");
        public_key = public_key.replace("-----END PUBLIC KEY-----", "");

        KeyFactory keyFactory = KeyFactory.getInstance("RSA", "SC");
        byte[] publicKeyBytes = Base64.decode(public_key.getBytes("UTF-8"), Base64.DEFAULT);
        X509EncodedKeySpec x509KeySpec = new X509EncodedKeySpec(publicKeyBytes);
        return keyFactory.generatePublic(x509KeySpec);
    }

    private static java.security.PrivateKey getRSAPrivateKeyFromString(String privateKey) throws Exception{
        String public_key = privateKey;
        public_key = public_key.replace("-----BEGIN PRIVATE KEY-----", "");
        public_key = public_key.replace("-----END PRIVATE KEY-----", "");


        StringBuilder pkcs8Lines = new StringBuilder();
        BufferedReader rdr = new BufferedReader(new StringReader(GlobalValue.getPrivateKeyGlobal()));
        String line;
        while ((line = rdr.readLine()) != null) {
            pkcs8Lines.append(line);
        }

        // Remove the "BEGIN" and "END" lines, as well as any whitespace

        String pkcs8Pem = pkcs8Lines.toString();
        pkcs8Pem = pkcs8Pem.replace("-----BEGIN PRIVATE KEY-----", "");
        pkcs8Pem = pkcs8Pem.replace("-----END PRIVATE KEY-----", "");
        pkcs8Pem = pkcs8Pem.replaceAll("\\s+","");

        // Base64 decode the result

        byte [] pkcs8EncodedBytes = Base64.decode(pkcs8Pem, Base64.DEFAULT);

        // extract the private key

        PKCS8EncodedKeySpec keySpec = new PKCS8EncodedKeySpec(pkcs8EncodedBytes);
        KeyFactory kf = KeyFactory.getInstance("RSA");
        java.security.PrivateKey privKey = kf.generatePrivate(keySpec);
        return privKey;
    }
}
