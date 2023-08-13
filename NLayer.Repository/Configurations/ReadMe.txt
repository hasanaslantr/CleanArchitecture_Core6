Bu klasörümüz de veri tabanı Configuration işlemlerini gerçekleştiriyoruz,

IEntityTypeConfiguration arayüzünü kullanarak veri tabanımız ile ilgili tabloların 
yapısını Entity yapısına uyguna hale getitmek ve veritabnında ki tablo yapısını entity yapısı
ile uyum sağlaması için kullnaıyoruz.

Örnke kod:

public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasOne(q => q.Class)
                  .WithMany()
                  .HasForeignKey(q => q.ClassId)
                  .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Subject)
                .WithMany()
                .HasForeignKey(q => q.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(q => q.Lesson)
                 .WithMany()
                 .HasForeignKey(q => q.LessonId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }

