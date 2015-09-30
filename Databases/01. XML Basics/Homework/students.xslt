﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
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
            <xsl:for-each select="students/student">
              <tr>
                <td>
                  <xsl:value-of select="name" />
                </td>
                <td>
                  <xsl:value-of select="sex" />
                </td>
                <td>
                  <xsl:value-of select="birthDate" />
                </td>
                <td>
                  <xsl:value-of select="phone" />
                </td>
                <td>
                  <xsl:value-of select="email" />
                </td>
                <td>
                  <xsl:value-of select="course" />
                </td>
                <td>
                  <xsl:value-of select="specialty" />
                </td>
                <td>
                  <xsl:value-of select="facultyNumber" />
                </td>
                <td>
                  <xsl:for-each select="students/student/exams">
                    <ul>
                      <li>
                        <xsl:value-of select="name" />
                      </li>
                      <li>
                        <xsl:value-of select="tutor" />
                      </li>
                      <li>
                        <xsl:value-of select="score" />
                      </li>
                    </ul>
                  </xsl:for-each>
                </td>
              </tr>
            </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>