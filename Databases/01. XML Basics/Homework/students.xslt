<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:st="urn:students">
  <xsl:template match="/">
    <html>
      <body>
        <table border="1">
          <tr>
            <th>Name</th>
            <th>Sex</th>
            <th>Birth Date</th>
            <th>Phone</th>
            <th>Email</th>
            <th>Course</th>
            <th>Specialty</th>
            <th>Faculty Number</th>
          </tr>
          <xsl:for-each select="st:students/st:student">
            <tr>
              <td>
                <xsl:value-of select="st:name" />
              </td>
              <td>
                <xsl:value-of select="st:sex" />
              </td>
              <td>
                <xsl:value-of select="st:birthDate" />
              </td>
              <td>
                <xsl:value-of select="st:phone" />
              </td>
              <td>
                <xsl:value-of select="st:email" />
              </td>
              <td>
                <xsl:value-of select="st:course" />
              </td>
              <td>
                <xsl:value-of select="st:specialty" />
              </td>
              <td>
                <xsl:value-of select="st:facultyNumber" />
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>