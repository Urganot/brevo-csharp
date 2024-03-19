/* 
 * Brevo API
 *
 * Brevo provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/brevo  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@brevo.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = brevo_csharp.Client.SwaggerDateConverter;

namespace brevo_csharp.Model
{
    /// <summary>
    /// File data that is uploaded
    /// </summary>
    [DataContract]
    public partial class FileData :  IEquatable<FileData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        /// <param name="name">Name of uploaded file.</param>
        /// <param name="authorId">Account id of user which created the file.</param>
        /// <param name="contactId">Contact id of contact on which file is uploaded.</param>
        /// <param name="dealId">Deal id linked to a file.</param>
        /// <param name="companyId">Company id linked to a file.</param>
        /// <param name="size">Size of file in bytes.</param>
        /// <param name="createdAt">File created date/time.</param>
        public FileData(string name = default(string), string authorId = default(string), long? contactId = default(long?), string dealId = default(string), string companyId = default(string), long? size = default(long?), DateTime? createdAt = default(DateTime?))
        {
            this.Name = name;
            this.AuthorId = authorId;
            this.ContactId = contactId;
            this.DealId = dealId;
            this.CompanyId = companyId;
            this.Size = size;
            this.CreatedAt = createdAt;
        }
        
        /// <summary>
        /// Name of uploaded file
        /// </summary>
        /// <value>Name of uploaded file</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Account id of user which created the file
        /// </summary>
        /// <value>Account id of user which created the file</value>
        [DataMember(Name="authorId", EmitDefaultValue=false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// Contact id of contact on which file is uploaded
        /// </summary>
        /// <value>Contact id of contact on which file is uploaded</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// Deal id linked to a file
        /// </summary>
        /// <value>Deal id linked to a file</value>
        [DataMember(Name="dealId", EmitDefaultValue=false)]
        public string DealId { get; set; }

        /// <summary>
        /// Company id linked to a file
        /// </summary>
        /// <value>Company id linked to a file</value>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Size of file in bytes
        /// </summary>
        /// <value>Size of file in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// File created date/time
        /// </summary>
        /// <value>File created date/time</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileData {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  DealId: ").Append(DealId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileData);
        }

        /// <summary>
        /// Returns true if FileData instances are equal
        /// </summary>
        /// <param name="input">Instance of FileData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.DealId == input.DealId ||
                    (this.DealId != null &&
                    this.DealId.Equals(input.DealId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    (this.CompanyId != null &&
                    this.CompanyId.Equals(input.CompanyId))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AuthorId != null)
                    hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.DealId != null)
                    hashCode = hashCode * 59 + this.DealId.GetHashCode();
                if (this.CompanyId != null)
                    hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}