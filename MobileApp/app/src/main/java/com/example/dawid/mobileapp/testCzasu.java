package com.example.dawid.mobileapp;

import android.content.Context;
import android.os.Debug;
import android.util.Base64;
import android.util.Log;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.ByteArrayInputStream;
import java.io.FileReader;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.StringReader;
import java.io.UnsupportedEncodingException;
import java.math.BigInteger;
import java.security.GeneralSecurityException;
import java.security.InvalidAlgorithmParameterException;
import java.security.InvalidKeyException;
import java.security.Key;
import java.security.KeyFactory;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.security.PrivateKey;
import java.security.PublicKey;
import java.security.SecureRandom;
import java.security.Security;
import java.security.Signature;
import java.security.cert.Certificate;
import java.security.cert.CertificateEncodingException;
import java.security.cert.CertificateException;
import java.security.cert.CertificateFactory;
import java.security.interfaces.RSAPublicKey;
import java.security.spec.InvalidKeySpecException;
import java.security.spec.KeySpec;
import java.security.spec.PKCS8EncodedKeySpec;
import java.security.spec.RSAPublicKeySpec;
import java.security.spec.X509EncodedKeySpec;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Arrays;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.SecureRandom;
import java.util.Date;
import java.util.List;

import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.KeyAgreement;
import javax.crypto.KeyGenerator;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.SecretKey;
import javax.crypto.spec.DHParameterSpec;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;
import javax.microedition.khronos.opengles.GL;
import javax.security.cert.CertificateExpiredException;
import javax.security.cert.CertificateNotYetValidException;
import javax.security.cert.X509Certificate;

import org.spongycastle.crypto.engines.GOST28147Engine;
import org.spongycastle.crypto.engines.RSAEngine;
import org.spongycastle.crypto.encodings.PKCS1Encoding;
import org.spongycastle.jce.provider.BouncyCastleProvider;
import org.spongycastle.util.io.pem.PemObject;
import org.spongycastle.util.io.pem.PemReader;
import org.spongycastle.x509.X509V1CertificateGenerator;

import static java.lang.System.in;
import static java.nio.charset.StandardCharsets.UTF_8;

/**
 * Created by Dawid on 12.12.2017.
 */

public final  class testCzasu
{

    static {
        Security.addProvider(new BouncyCastleProvider());
    }
    public static void testy(){
        Log.d("czas czasu", "data");

        SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSSZ") ;
        Date now = new Date();
        Log.d("czas czasudr ", dateFormat.format(now));
        String date = "2017-12-14T14:16:02.754+0000";
        String asda = "2017-12-14T13:33:16.179401+01:00";
        try {
            Date nowa = dateFormat.parse(date);
            Log.d("czas czasudr123 ", dateFormat.format(nowa));
            Log.d("czas", String.valueOf(nowa.compareTo(now)));
            if(nowa.after(now))
            {
            Log.d("czas", "tutaj");
            }
            if(nowa.before(now))
            {
                Log.d("czas", "drugi");
            }

        } catch (ParseException e) {
            e.printStackTrace();
        }

        /*  DatePicker dp = (DatePicker)findViewById(R.id.datePickerDelayed);
        TimePicker tp = (TimePicker)findViewById(R.id.timePickerDel);
        Date myDbDate = new Date(dp.getYear(), dp.getMonth(), dp.getDayOfMonth(), tp.getCurrentHour(), tp.getCurrentMinute());
        Calendar calendar =*/
    }

    public static PrivateKey loadKey(String data) throws IOException
    {
        try
        {
            // need to use some BC classes to parse PEM files
            // fecking Java, POS at times
            PemReader pr = new PemReader(new StringReader(data));
            try
            {
                PemObject obj = pr.readPemObject();
                KeyFactory kf = KeyFactory.getInstance("RSA");
                PrivateKey key = kf.generatePrivate(new PKCS8EncodedKeySpec(obj.getContent()));
                return key;
            }
            finally
            {
                pr.close();
            }
        }
        catch (Exception e)
        {
            throw new IOException("Error loading key", e);
        }
    }

  /*  public  static void asdasd(){
        // encode
        byte[] value_bytes = Base64.decode("asdasd", 0);
        String ps = "techPass";
        String tmp = Base64.encodeBytes(ps.getBytes());
var asdb = Base64.getEncoder();
// decode
        String ps2 = "dGVjaFBhC3M=";
        byte[] tmp2 = Base64.decode(ps2, 0);
        String val2 = new String(tmp2, "UTF-8");
    }
    public static X509Certificate parseCertificate(String _headerName) throws CertificateException{

        byte [] is = Base64.decode("", 0);
        CertificateFactory cf = null;
        try {
            cf = CertificateFactory.getInstance("X.509");
            Certificate cert = cf.generateCertificate();
        } catch (CertificateException e) {
            e.printStackTrace();
        }

        String certStr = "";
        byte[] data = Base64.decode("asdasd", Base64.DEFAULT);
        //before decoding we need to get rod off the prefix and suffix
        byte [] decoded = Base64.decode(certStr.replaceAll(X509Factory.BEGIN_CERT, "").replaceAll(X509Factory.END_CERT, ""));

        return (X509Certificate)CertificateFactory.getInstance("X.509").generateCertificate(new ByteArrayInputStream(decoded));
    }

*/

  /*  public java.security.cert.X509Certificate convertToX509Certificate(String pem) throws CertificateException, IOException {
        java.security.cert.X509Certificate cert = null;
        StringReader reader = new StringReader(pem);
        PemReader pr = new PemReader(reader);

        cert = (java.security.cert.X509Certificate)pr.readPemObject();
        return cert;
    }


*/





    public static java.security.cert.X509Certificate convertToX509Cert(String certificateString) throws CertificateException {
        X509Certificate certificate = null;
        CertificateFactory cf = CertificateFactory.getInstance("X509");
        try {
            if (certificateString != null && !certificateString.trim().isEmpty()) {
                certificateString = certificateString.replace("-----BEGIN CERTIFICATE-----\n", "")
                        .replace("-----END CERTIFICATE-----", ""); // NEED FOR PEM FORMAT CERT STRING
                byte[] certificateData = Base64.decode(certificateString, 0);
                ByteArrayInputStream bytr = new ByteArrayInputStream(certificateData);
                java.security.cert.CertificateFactory cfa
                        = java.security.cert.CertificateFactory.getInstance("X.509");
                java.security.cert.X509Certificate certificate1 = (java.security.cert.X509Certificate)cf.generateCertificate(bytr);

                return certificate1;

             //   certificate = (java.security.cert.X509Certificate)cf.generateCertificate(new ByteArrayInputStream(certificateData));
            }

        } catch (CertificateException e) {
            throw new CertificateException(e);
        }
        return null;
    }


    public static java.security.cert.X509Certificate convertToX509Cert123(String certificateString) throws CertificateException {
        X509Certificate certificate = null;
        CertificateFactory cf = CertificateFactory.getInstance("X509");
        try {
            if (certificateString != null && !certificateString.trim().isEmpty()) {
                certificateString = certificateString.replace("-----BEGIN CERTIFICATE-----\n", "")
                        .replace("-----END CERTIFICATE-----", ""); // NEED FOR PEM FORMAT CERT STRING
                byte[] certificateData = Base64.decode(certificateString, 0);
                ByteArrayInputStream bytr = new ByteArrayInputStream(certificateData);
                java.security.cert.CertificateFactory cfa
                        = java.security.cert.CertificateFactory.getInstance("X.509");
                java.security.cert.X509Certificate certificate1 = (java.security.cert.X509Certificate)cf.generateCertificate(bytr);

                StringReader reader = new StringReader(certificateString);
                PemReader pr = new PemReader(reader);
                Object obj = pr.readPemObject();

                    // Just in case your file contains in fact an X.509 certificate,
                    // useless otherwise.
                    obj = ((X509Certificate)obj).getPublicKey();
                    Log.d("keys, ", obj.toString());

                PublicKey pk = certificate1.getPublicKey();

                RSAPublicKey rsaKey = (RSAPublicKey) (pk);
                BigInteger modulus = rsaKey.getModulus();
                BigInteger publicExponent = rsaKey.getPublicExponent();

                org.spongycastle.crypto.encodings.PKCS1Encoding encryptEngine = new PKCS1Encoding(new RSAEngine());
              //  encryptEngine.init(true, rsaKey);
             //   X509Certificate a = (javax.security.cert.X509Certificate)pr;
                return certificate1;

                //   certificate = (java.security.cert.X509Certificate)cf.generateCertificate(new ByteArrayInputStream(certificateData));
            }

        } catch (CertificateException e) {
            throw new CertificateException(e);
        } catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }





    static String enccriptData(String txt)
    {
        String encoded = "";
        byte[] encrypted = null;
        try {
            byte[] publicBytes = Base64.decode(GlobalValue.getPublicKeyGlobal(), Base64.DEFAULT);
            X509EncodedKeySpec keySpec = new X509EncodedKeySpec(publicBytes);
            KeyFactory keyFactory = KeyFactory.getInstance("RSA");
            PublicKey pubKey = getRSAPublicKeyFromString();
            Cipher cipher = Cipher.getInstance("RSA/ECB/PKCS1PADDING"); //or try with "RSA"
            cipher.init(Cipher.ENCRYPT_MODE, pubKey);
            encrypted = cipher.doFinal(txt.getBytes());
            encoded = Base64.encodeToString(encrypted, Base64.DEFAULT);
            Log.d("szyfrowanie", encoded);
        }
        catch (Exception e) {
            e.printStackTrace();
        }
        return encoded;
    }

    private void stripHeaders(){
        String public_key = GlobalValue.getPublicKeyGlobal();
        public_key = public_key.replace("-----BEGIN PUBLIC KEY-----", "");
        public_key = public_key.replace("-----END PUBLIC KEY-----", "");

    }

    public static byte[] encryptWithPublicKey(String encrypt) throws Exception {
        String public_key = GlobalValue.getPublicKeyGlobal();
        public_key = public_key.replace("-----BEGIN PUBLIC KEY-----", "");
        public_key = public_key.replace("-----END PUBLIC KEY-----", "");

        byte[] message = encrypt.getBytes("UTF-8");

        PublicKey apiPublicKey= getRSAPublicKeyFromString();
        Cipher rsaCipher = Cipher.getInstance("RSA/None/PKCS1Padding", "SC");
        rsaCipher.init(Cipher.ENCRYPT_MODE, apiPublicKey);

        byte [] encrypted = rsaCipher.doFinal(message);
        String encoded  =Base64.encodeToString(encrypted, Base64.DEFAULT);

        return rsaCipher.doFinal(message);
    }

    private static PublicKey getRSAPublicKeyFromString() throws Exception{
        String public_key = GlobalValue.getPublicKeyGlobal();
        public_key = public_key.replace("-----BEGIN PUBLIC KEY-----", "");
        public_key = public_key.replace("-----END PUBLIC KEY-----", "");
        Log.d("publickey22 ", public_key );
        KeyFactory keyFactory = KeyFactory.getInstance("RSA", "SC");
        byte[] publicKeyBytes = Base64.decode(public_key.getBytes("UTF-8"), Base64.DEFAULT);
        X509EncodedKeySpec x509KeySpec = new X509EncodedKeySpec(publicKeyBytes);
        return keyFactory.generatePublic(x509KeySpec);
    }

    private static PrivateKey getRSAPrivateKeyFromString(String privateKey) throws Exception{
        String public_key = privateKey;
        public_key = public_key.replace("-----BEGIN PRIVATE KEY-----", "");
        public_key = public_key.replace("-----END PRIVATE KEY-----", "");
        Log.d("publickey22 ", public_key );
        KeyFactory keyFactory = KeyFactory.getInstance("RSA", "SC");
        byte[] publicKeyBytes = Base64.decode(public_key.getBytes("UTF-8"), Base64.DEFAULT);
        X509EncodedKeySpec x509KeySpec = new X509EncodedKeySpec(publicKeyBytes);


        // Read in the key into a String

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
        PrivateKey privKey = kf.generatePrivate(keySpec);
        Log.d("szyfrowanie0P ", privKey.toString());
        return privKey;
    }
    public static void generatePublicKey(String certificateString)
    {

        byte[] certificateData = Base64.decode(certificateString, 0);
        ByteArrayInputStream bytr = new ByteArrayInputStream(certificateData);
        ObjectInputStream oin = null;

        try
        {

            oin = new ObjectInputStream(new BufferedInputStream(in));

            BigInteger m = (BigInteger) oin.readObject();
            BigInteger e = (BigInteger) oin.readObject();
            RSAPublicKeySpec keySpec = new RSAPublicKeySpec(m, e);
            KeyFactory fact = KeyFactory.getInstance("RSA");
            PublicKey a = fact.generatePublic(keySpec);
            Log.d("gen ", a.toString());
        }
        catch (Throwable e)
        {

        }
        finally
        {
            if (in != null)
            {
                try {in.close();} catch (Throwable t) {}
            }

            if (oin != null)
            {
                try {oin.close();} catch (Throwable t) {}
            }
        }
    }
    public static String decrypt(String encryptedMessage, Key key)
    {
        String messageString = null;
        try
        {
            byte[] cipherData = Base64.decode(encryptedMessage, 0);
            String algorithm = key.getAlgorithm();
            Cipher cipher = Cipher.getInstance(algorithm);
            cipher.init(Cipher.DECRYPT_MODE, key);
            byte[] messageBytes = cipher.doFinal(cipherData);
            messageString = new String(messageBytes);
        }
        catch (Throwable t)
        {

        }

        return messageString;
    }

    public static String stripPublicKeyHeaders(String key) {
        //strip the headers from the key string
        StringBuilder strippedKey = new StringBuilder();
        String lines[] = key.split("\n");
        for(String line : lines) {
            if(!line.contains("BEGIN PUBLIC KEY") && !line.contains("END PUBLIC KEY")) {
                strippedKey.append(line.trim());
            }
        }
        return strippedKey.toString().trim();
    }






    public static PublicKey getRSAPublicKeyFromString(String apiKey) throws Exception{
        KeyFactory keyFactory = KeyFactory.getInstance("RSA", "SC");
        byte[] publicKeyBytes = Base64.decode(apiKey.getBytes("UTF-8"), Base64.DEFAULT);
        X509EncodedKeySpec x509KeySpec = new X509EncodedKeySpec(publicKeyBytes);
        return keyFactory.generatePublic(x509KeySpec);
    }
 /*   public  static  String das123(String datee) throws NoSuchAlgorithmException, InvalidKeySpecException, CertificateException {

        java.security.cert.X509Certificate cert = convertToX509Cert(datee);
        X509EncodedKeySpec ks = new X509EncodedKeySpec(cert.ke);
        KeyFactory kf = KeyFactory.getInstance("RSA");
        PublicKey pub = kf.generatePublic(ks);
        Log.d("logowanie123123, ", pub.toString());
        return  "abc";
    }
*/
    public static java.security.cert.X509Certificate convert(javax.security.cert.X509Certificate cert) {
        try {
            byte[] encoded = cert.getEncoded();
            ByteArrayInputStream bis = new ByteArrayInputStream(encoded);
            java.security.cert.CertificateFactory cf
                    = java.security.cert.CertificateFactory.getInstance("X.509");
            return (java.security.cert.X509Certificate)cf.generateCertificate(bis);
        } catch (java.security.cert.CertificateEncodingException e) {
        } catch (javax.security.cert.CertificateEncodingException e) {
        } catch (java.security.cert.CertificateException e) {
        }
        return null;
    }



   /* public static void cert123()
    {
        X509Certificate cert =X509CertUtils.parse();
    }*/



    public static String Szyfowanie(String dataToEncrypt) throws Exception {
        // generate a new public/private key pair to test with (note. you should only do this once and keep them!)
       // PublicKey apiPublicKey= getRSAPublicKeyFromString();

        // PublicKey publicKey = kp.getPublic();
      //  byte[] publicKeyBytes = apiPublicKey.getEncoded();
     //   String publicKeyBytesBase64 = new String(Base64.encode(publicKeyBytes, Base64.DEFAULT));


        // test encryption
       // String encrypted = encryptRSAToString(dataToEncrypt, publicKeyBytesBase64);

        // moje
       /* String otherCert = "";
        for(Users x : GlobalValue.getUsersListGlobal())
        {
            if(x.getID() == ID)
            {
                otherCert = x.getCert();
            }
        }*/
        java.security.cert.X509Certificate certy = testCzasu.convertToX509Cert(GlobalValue.getUserSend().getCert());
        Log.d("cosss", certy.getPublicKey().toString());
        PublicKey pk = certy.getPublicKey();
        byte[] publicKeyBytes1 = pk.getEncoded();
        String publicKeyBytesBase641 = new String(Base64.encode(publicKeyBytes1, Base64.DEFAULT));
        String encrypted1 = encryptRSAToString(dataToEncrypt, publicKeyBytesBase641);
return  encrypted1;

    }

    public static String SzyfowanieCopy(String dataToEncrypt) throws Exception {

        java.security.cert.X509Certificate certy = testCzasu.convertToX509Cert(GlobalValue.getPublicCertificateGlobal());
        Log.d("cosss", certy.getPublicKey().toString());
        PublicKey pk = certy.getPublicKey();
        byte[] publicKeyBytes1 = pk.getEncoded();
        String publicKeyBytesBase641 = new String(Base64.encode(publicKeyBytes1, Base64.DEFAULT));
        String encrypted1 = encryptRSAToString(dataToEncrypt, publicKeyBytesBase641);
        return  encrypted1;

    }

    public static String Odszyfrowanie(String dataToDecrypt, String IDCert) throws Exception {

        String privateK = "";
        for (com.example.dawid.mobileapp.PrivateKeyObject x: GlobalValue.getPrivateKeysList())
        {
            if(IDCert.equals(x.getID()))
                privateK = x.getCertyficate();
        }
        PrivateKey privateKey = getRSAPrivateKeyFromString(privateK);
        byte[] privateKeyBytes = privateKey.getEncoded();
        String privateKeyBytesBase64 = new String(Base64.encode(privateKeyBytes, Base64.DEFAULT));
        String decrypted = decryptRSAToString(dataToDecrypt, privateKeyBytesBase64);
        return  decrypted;
    }



    public static void TestEncryptData(String dataToEncrypt) throws Exception {
        // generate a new public/private key pair to test with (note. you should only do this once and keep them!)
         PublicKey apiPublicKey= getRSAPublicKeyFromString();

       // PublicKey publicKey = kp.getPublic();
        byte[] publicKeyBytes = apiPublicKey.getEncoded();
        String publicKeyBytesBase64 = new String(Base64.encode(publicKeyBytes, Base64.DEFAULT));

        PrivateKey privateKey = getRSAPrivateKeyFromString("");
        byte[] privateKeyBytes = privateKey.getEncoded();
        String privateKeyBytesBase64 = new String(Base64.encode(privateKeyBytes, Base64.DEFAULT));

        // test encryption
        String encrypted = encryptRSAToString(dataToEncrypt, publicKeyBytesBase64);
        Log.d("keypublic", apiPublicKey.toString());
        Log.d("keypublic1", publicKeyBytesBase64);
        Log.d("keypublic2", privateKey.toString());
        Log.d("keypublic3", privateKeyBytesBase64);
Log.d("szyfrowanie00", encrypted);
        // test decryption
        String decrypted = decryptRSAToString(encrypted, privateKeyBytesBase64);
    Log.d("szyfrowanie01", decrypted);


    // moje
        java.security.cert.X509Certificate certy = testCzasu.convertToX509Cert(GlobalValue.getPublicCertificateGlobal());
        PublicKey pk = certy.getPublicKey();
        byte[] publicKeyBytes1 = pk.getEncoded();
        String publicKeyBytesBase641 = new String(Base64.encode(publicKeyBytes1, Base64.DEFAULT));
        String encrypted1 = encryptRSAToString(dataToEncrypt, publicKeyBytesBase641);

        Log.d("szyfrowanie001", encrypted1);
        String decrypted1 = decryptRSAToString(encrypted1, privateKeyBytesBase64);
        Log.d("szyfrowanie011", decrypted1);
    }

    public static KeyPair getKeyPair() {
        KeyPair kp = null;
        try {
            KeyPairGenerator kpg = KeyPairGenerator.getInstance("RSA");
            kpg.initialize(1024);
            kp = kpg.generateKeyPair();
        } catch (Exception e) {
            e.printStackTrace();
        }

        return kp;
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
}
