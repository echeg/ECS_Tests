using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System0 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component258> _p1;
EcsPool<Component292> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component258>().Inc<Component292>().End();
   _p1 = _world.GetPool<Component258>();
   _p2 = _world.GetPool<Component292>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System1 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component453> _p1;
EcsPool<Component118> _p2;
EcsPool<Component43> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component453>().Inc<Component118>().Inc<Component43>().End();
   _p1 = _world.GetPool<Component453>();
   _p2 = _world.GetPool<Component118>();
   _p3 = _world.GetPool<Component43>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System2 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component19> _p1;
EcsPool<Component313> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component19>().Inc<Component313>().End();
   _p1 = _world.GetPool<Component19>();
   _p2 = _world.GetPool<Component313>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System3 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component435> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component435>().End();
   _p1 = _world.GetPool<Component435>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System4 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component346> _p1;
EcsPool<Component144> _p2;
EcsPool<Component409> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component346>().Inc<Component144>().Inc<Component409>().End();
   _p1 = _world.GetPool<Component346>();
   _p2 = _world.GetPool<Component144>();
   _p3 = _world.GetPool<Component409>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System5 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component154> _p1;
EcsPool<Component322> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component154>().Inc<Component322>().End();
   _p1 = _world.GetPool<Component154>();
   _p2 = _world.GetPool<Component322>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System6 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component209> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component209>().End();
   _p1 = _world.GetPool<Component209>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System7 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component493> _p1;
EcsPool<Component122> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component493>().Inc<Component122>().End();
   _p1 = _world.GetPool<Component493>();
   _p2 = _world.GetPool<Component122>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System8 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component375> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().Inc<Component375>().End();
   _p1 = _world.GetPool<Component224>();
   _p2 = _world.GetPool<Component375>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System9 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component229> _p1;
EcsPool<Component281> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component229>().Inc<Component281>().End();
   _p1 = _world.GetPool<Component229>();
   _p2 = _world.GetPool<Component281>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System10 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component492> _p2;
EcsPool<Component292> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component492>().Inc<Component292>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component492>();
   _p3 = _world.GetPool<Component292>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System11 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component103> _p1;
EcsPool<Component418> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component103>().Inc<Component418>().End();
   _p1 = _world.GetPool<Component103>();
   _p2 = _world.GetPool<Component418>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System12 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component38> _p1;
EcsPool<Component292> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component38>().Inc<Component292>().End();
   _p1 = _world.GetPool<Component38>();
   _p2 = _world.GetPool<Component292>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System13 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component306> _p1;
EcsPool<Component378> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component306>().Inc<Component378>().End();
   _p1 = _world.GetPool<Component306>();
   _p2 = _world.GetPool<Component378>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System14 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component47> _p1;
EcsPool<Component386> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component47>().Inc<Component386>().End();
   _p1 = _world.GetPool<Component47>();
   _p2 = _world.GetPool<Component386>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System15 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component59> _p1;
EcsPool<Component232> _p2;
EcsPool<Component42> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component59>().Inc<Component232>().Inc<Component42>().End();
   _p1 = _world.GetPool<Component59>();
   _p2 = _world.GetPool<Component232>();
   _p3 = _world.GetPool<Component42>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System16 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component454> _p1;
EcsPool<Component133> _p2;
EcsPool<Component286> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component454>().Inc<Component133>().Inc<Component286>().End();
   _p1 = _world.GetPool<Component454>();
   _p2 = _world.GetPool<Component133>();
   _p3 = _world.GetPool<Component286>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System17 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component30> _p1;
EcsPool<Component265> _p2;
EcsPool<Component170> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component30>().Inc<Component265>().Inc<Component170>().End();
   _p1 = _world.GetPool<Component30>();
   _p2 = _world.GetPool<Component265>();
   _p3 = _world.GetPool<Component170>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System18 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component228> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component228>().End();
   _p1 = _world.GetPool<Component228>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System19 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component269> _p1;
EcsPool<Component495> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component269>().Inc<Component495>().End();
   _p1 = _world.GetPool<Component269>();
   _p2 = _world.GetPool<Component495>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System20 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component450> _p1;
EcsPool<Component160> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component450>().Inc<Component160>().End();
   _p1 = _world.GetPool<Component450>();
   _p2 = _world.GetPool<Component160>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System21 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component168> _p1;
EcsPool<Component97> _p2;
EcsPool<Component40> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component168>().Inc<Component97>().Inc<Component40>().End();
   _p1 = _world.GetPool<Component168>();
   _p2 = _world.GetPool<Component97>();
   _p3 = _world.GetPool<Component40>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System22 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component4> _p1;
EcsPool<Component116> _p2;
EcsPool<Component29> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component4>().Inc<Component116>().Inc<Component29>().End();
   _p1 = _world.GetPool<Component4>();
   _p2 = _world.GetPool<Component116>();
   _p3 = _world.GetPool<Component29>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System23 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component328> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component328>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component328>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System24 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component74> _p1;
EcsPool<Component393> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component74>().Inc<Component393>().End();
   _p1 = _world.GetPool<Component74>();
   _p2 = _world.GetPool<Component393>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System25 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component315> _p1;
EcsPool<Component42> _p2;
EcsPool<Component186> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component315>().Inc<Component42>().Inc<Component186>().End();
   _p1 = _world.GetPool<Component315>();
   _p2 = _world.GetPool<Component42>();
   _p3 = _world.GetPool<Component186>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System26 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component408> _p1;
EcsPool<Component268> _p2;
EcsPool<Component206> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component408>().Inc<Component268>().Inc<Component206>().End();
   _p1 = _world.GetPool<Component408>();
   _p2 = _world.GetPool<Component268>();
   _p3 = _world.GetPool<Component206>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System27 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component218> _p1;
EcsPool<Component337> _p2;
EcsPool<Component248> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component218>().Inc<Component337>().Inc<Component248>().End();
   _p1 = _world.GetPool<Component218>();
   _p2 = _world.GetPool<Component337>();
   _p3 = _world.GetPool<Component248>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System28 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component309> _p1;
EcsPool<Component48> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component309>().Inc<Component48>().End();
   _p1 = _world.GetPool<Component309>();
   _p2 = _world.GetPool<Component48>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System29 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component311> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component311>().End();
   _p1 = _world.GetPool<Component311>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System30 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component249> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component249>().End();
   _p1 = _world.GetPool<Component249>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System31 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component443> _p1;
EcsPool<Component202> _p2;
EcsPool<Component461> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component443>().Inc<Component202>().Inc<Component461>().End();
   _p1 = _world.GetPool<Component443>();
   _p2 = _world.GetPool<Component202>();
   _p3 = _world.GetPool<Component461>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System32 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component51> _p1;
EcsPool<Component346> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component51>().Inc<Component346>().End();
   _p1 = _world.GetPool<Component51>();
   _p2 = _world.GetPool<Component346>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System33 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component104> _p1;
EcsPool<Component54> _p2;
EcsPool<Component451> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component104>().Inc<Component54>().Inc<Component451>().End();
   _p1 = _world.GetPool<Component104>();
   _p2 = _world.GetPool<Component54>();
   _p3 = _world.GetPool<Component451>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System34 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component472> _p1;
EcsPool<Component95> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component472>().Inc<Component95>().End();
   _p1 = _world.GetPool<Component472>();
   _p2 = _world.GetPool<Component95>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System35 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component374> _p1;
EcsPool<Component428> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component374>().Inc<Component428>().End();
   _p1 = _world.GetPool<Component374>();
   _p2 = _world.GetPool<Component428>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System36 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component308> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component308>().End();
   _p1 = _world.GetPool<Component308>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System37 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component392> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component392>().End();
   _p1 = _world.GetPool<Component392>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System38 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component228> _p1;
EcsPool<Component379> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component228>().Inc<Component379>().End();
   _p1 = _world.GetPool<Component228>();
   _p2 = _world.GetPool<Component379>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System39 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component242> _p1;
EcsPool<Component315> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component242>().Inc<Component315>().End();
   _p1 = _world.GetPool<Component242>();
   _p2 = _world.GetPool<Component315>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System40 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component480> _p1;
EcsPool<Component193> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component480>().Inc<Component193>().End();
   _p1 = _world.GetPool<Component480>();
   _p2 = _world.GetPool<Component193>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System41 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component188> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component188>().End();
   _p1 = _world.GetPool<Component188>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System42 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component187> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component187>().End();
   _p1 = _world.GetPool<Component187>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System43 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component152> _p1;
EcsPool<Component354> _p2;
EcsPool<Component350> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component152>().Inc<Component354>().Inc<Component350>().End();
   _p1 = _world.GetPool<Component152>();
   _p2 = _world.GetPool<Component354>();
   _p3 = _world.GetPool<Component350>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System44 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component83> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component83>().End();
   _p1 = _world.GetPool<Component83>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System45 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component163> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component163>().End();
   _p1 = _world.GetPool<Component163>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System46 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component488> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component488>().End();
   _p1 = _world.GetPool<Component488>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System47 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component365> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component365>().End();
   _p1 = _world.GetPool<Component365>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System48 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component21> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component21>().End();
   _p1 = _world.GetPool<Component21>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System49 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component120> _p1;
EcsPool<Component311> _p2;
EcsPool<Component2> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component120>().Inc<Component311>().Inc<Component2>().End();
   _p1 = _world.GetPool<Component120>();
   _p2 = _world.GetPool<Component311>();
   _p3 = _world.GetPool<Component2>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System50 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component206> _p1;
EcsPool<Component494> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component206>().Inc<Component494>().End();
   _p1 = _world.GetPool<Component206>();
   _p2 = _world.GetPool<Component494>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System51 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component473> _p1;
EcsPool<Component82> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component473>().Inc<Component82>().End();
   _p1 = _world.GetPool<Component473>();
   _p2 = _world.GetPool<Component82>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System52 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component309> _p1;
EcsPool<Component31> _p2;
EcsPool<Component30> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component309>().Inc<Component31>().Inc<Component30>().End();
   _p1 = _world.GetPool<Component309>();
   _p2 = _world.GetPool<Component31>();
   _p3 = _world.GetPool<Component30>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System53 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component360> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component360>().End();
   _p1 = _world.GetPool<Component360>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System54 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component427> _p2;
EcsPool<Component407> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component427>().Inc<Component407>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component427>();
   _p3 = _world.GetPool<Component407>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System55 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component222> _p1;
EcsPool<Component73> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component222>().Inc<Component73>().End();
   _p1 = _world.GetPool<Component222>();
   _p2 = _world.GetPool<Component73>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System56 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component173> _p1;
EcsPool<Component224> _p2;
EcsPool<Component472> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component173>().Inc<Component224>().Inc<Component472>().End();
   _p1 = _world.GetPool<Component173>();
   _p2 = _world.GetPool<Component224>();
   _p3 = _world.GetPool<Component472>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System57 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component84> _p1;
EcsPool<Component240> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component84>().Inc<Component240>().End();
   _p1 = _world.GetPool<Component84>();
   _p2 = _world.GetPool<Component240>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System58 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component337> _p1;
EcsPool<Component89> _p2;
EcsPool<Component293> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component337>().Inc<Component89>().Inc<Component293>().End();
   _p1 = _world.GetPool<Component337>();
   _p2 = _world.GetPool<Component89>();
   _p3 = _world.GetPool<Component293>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System59 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component359> _p1;
EcsPool<Component381> _p2;
EcsPool<Component88> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component359>().Inc<Component381>().Inc<Component88>().End();
   _p1 = _world.GetPool<Component359>();
   _p2 = _world.GetPool<Component381>();
   _p3 = _world.GetPool<Component88>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System60 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component337> _p1;
EcsPool<Component193> _p2;
EcsPool<Component243> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component337>().Inc<Component193>().Inc<Component243>().End();
   _p1 = _world.GetPool<Component337>();
   _p2 = _world.GetPool<Component193>();
   _p3 = _world.GetPool<Component243>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System61 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component271> _p1;
EcsPool<Component362> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component271>().Inc<Component362>().End();
   _p1 = _world.GetPool<Component271>();
   _p2 = _world.GetPool<Component362>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System62 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component52> _p1;
EcsPool<Component39> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component52>().Inc<Component39>().End();
   _p1 = _world.GetPool<Component52>();
   _p2 = _world.GetPool<Component39>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System63 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component291> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component291>().End();
   _p1 = _world.GetPool<Component291>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System64 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component3> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component3>().End();
   _p1 = _world.GetPool<Component3>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System65 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component305> _p2;
EcsPool<Component212> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component305>().Inc<Component212>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component305>();
   _p3 = _world.GetPool<Component212>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System66 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component435> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component435>().End();
   _p1 = _world.GetPool<Component435>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System67 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component107> _p1;
EcsPool<Component234> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component107>().Inc<Component234>().End();
   _p1 = _world.GetPool<Component107>();
   _p2 = _world.GetPool<Component234>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System68 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component122> _p1;
EcsPool<Component233> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component122>().Inc<Component233>().End();
   _p1 = _world.GetPool<Component122>();
   _p2 = _world.GetPool<Component233>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System69 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component150> _p1;
EcsPool<Component220> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component150>().Inc<Component220>().End();
   _p1 = _world.GetPool<Component150>();
   _p2 = _world.GetPool<Component220>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System70 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component158> _p1;
EcsPool<Component265> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component158>().Inc<Component265>().End();
   _p1 = _world.GetPool<Component158>();
   _p2 = _world.GetPool<Component265>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System71 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component270> _p1;
EcsPool<Component156> _p2;
EcsPool<Component90> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component270>().Inc<Component156>().Inc<Component90>().End();
   _p1 = _world.GetPool<Component270>();
   _p2 = _world.GetPool<Component156>();
   _p3 = _world.GetPool<Component90>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System72 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component473> _p1;
EcsPool<Component43> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component473>().Inc<Component43>().End();
   _p1 = _world.GetPool<Component473>();
   _p2 = _world.GetPool<Component43>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System73 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component348> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component348>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component348>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System74 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component432> _p1;
EcsPool<Component190> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component432>().Inc<Component190>().End();
   _p1 = _world.GetPool<Component432>();
   _p2 = _world.GetPool<Component190>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System75 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component111> _p1;
EcsPool<Component358> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component111>().Inc<Component358>().End();
   _p1 = _world.GetPool<Component111>();
   _p2 = _world.GetPool<Component358>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System76 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component343> _p1;
EcsPool<Component488> _p2;
EcsPool<Component159> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component343>().Inc<Component488>().Inc<Component159>().End();
   _p1 = _world.GetPool<Component343>();
   _p2 = _world.GetPool<Component488>();
   _p3 = _world.GetPool<Component159>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System77 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component446> _p1;
EcsPool<Component260> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component446>().Inc<Component260>().End();
   _p1 = _world.GetPool<Component446>();
   _p2 = _world.GetPool<Component260>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System78 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component102> _p1;
EcsPool<Component427> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component102>().Inc<Component427>().End();
   _p1 = _world.GetPool<Component102>();
   _p2 = _world.GetPool<Component427>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System79 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component445> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component445>().End();
   _p1 = _world.GetPool<Component445>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System80 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component212> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component212>().End();
   _p1 = _world.GetPool<Component212>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System81 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component315> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component315>().End();
   _p1 = _world.GetPool<Component315>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System82 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component273> _p1;
EcsPool<Component312> _p2;
EcsPool<Component357> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component273>().Inc<Component312>().Inc<Component357>().End();
   _p1 = _world.GetPool<Component273>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component357>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System83 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component347> _p1;
EcsPool<Component31> _p2;
EcsPool<Component331> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component347>().Inc<Component31>().Inc<Component331>().End();
   _p1 = _world.GetPool<Component347>();
   _p2 = _world.GetPool<Component31>();
   _p3 = _world.GetPool<Component331>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System84 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component421> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component421>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component421>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System85 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component435> _p1;
EcsPool<Component301> _p2;
EcsPool<Component75> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component435>().Inc<Component301>().Inc<Component75>().End();
   _p1 = _world.GetPool<Component435>();
   _p2 = _world.GetPool<Component301>();
   _p3 = _world.GetPool<Component75>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System86 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component121> _p1;
EcsPool<Component362> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component121>().Inc<Component362>().End();
   _p1 = _world.GetPool<Component121>();
   _p2 = _world.GetPool<Component362>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System87 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component376> _p1;
EcsPool<Component249> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component376>().Inc<Component249>().End();
   _p1 = _world.GetPool<Component376>();
   _p2 = _world.GetPool<Component249>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System88 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component453> _p1;
EcsPool<Component31> _p2;
EcsPool<Component10> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component453>().Inc<Component31>().Inc<Component10>().End();
   _p1 = _world.GetPool<Component453>();
   _p2 = _world.GetPool<Component31>();
   _p3 = _world.GetPool<Component10>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System89 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component487> _p1;
EcsPool<Component287> _p2;
EcsPool<Component352> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component487>().Inc<Component287>().Inc<Component352>().End();
   _p1 = _world.GetPool<Component487>();
   _p2 = _world.GetPool<Component287>();
   _p3 = _world.GetPool<Component352>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System90 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component250> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component250>().End();
   _p1 = _world.GetPool<Component250>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System91 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component242> _p1;
EcsPool<Component356> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component242>().Inc<Component356>().End();
   _p1 = _world.GetPool<Component242>();
   _p2 = _world.GetPool<Component356>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System92 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component416> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component416>().End();
   _p1 = _world.GetPool<Component416>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System93 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component254> _p1;
EcsPool<Component11> _p2;
EcsPool<Component52> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component254>().Inc<Component11>().Inc<Component52>().End();
   _p1 = _world.GetPool<Component254>();
   _p2 = _world.GetPool<Component11>();
   _p3 = _world.GetPool<Component52>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System94 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component156> _p1;
EcsPool<Component490> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component156>().Inc<Component490>().End();
   _p1 = _world.GetPool<Component156>();
   _p2 = _world.GetPool<Component490>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System95 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component25> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component25>().End();
   _p1 = _world.GetPool<Component25>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System96 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component312> _p1;
EcsPool<Component301> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component312>().Inc<Component301>().End();
   _p1 = _world.GetPool<Component312>();
   _p2 = _world.GetPool<Component301>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System97 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component291> _p1;
EcsPool<Component324> _p2;
EcsPool<Component189> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component291>().Inc<Component324>().Inc<Component189>().End();
   _p1 = _world.GetPool<Component291>();
   _p2 = _world.GetPool<Component324>();
   _p3 = _world.GetPool<Component189>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System98 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component229> _p1;
EcsPool<Component66> _p2;
EcsPool<Component382> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component229>().Inc<Component66>().Inc<Component382>().End();
   _p1 = _world.GetPool<Component229>();
   _p2 = _world.GetPool<Component66>();
   _p3 = _world.GetPool<Component382>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System99 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component280> _p1;
EcsPool<Component347> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component280>().Inc<Component347>().End();
   _p1 = _world.GetPool<Component280>();
   _p2 = _world.GetPool<Component347>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System100 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component360> _p1;
EcsPool<Component244> _p2;
EcsPool<Component479> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component360>().Inc<Component244>().Inc<Component479>().End();
   _p1 = _world.GetPool<Component360>();
   _p2 = _world.GetPool<Component244>();
   _p3 = _world.GetPool<Component479>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System101 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component494> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component494>().End();
   _p1 = _world.GetPool<Component494>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System102 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component237> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component237>().End();
   _p1 = _world.GetPool<Component237>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System103 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component250> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component250>().End();
   _p1 = _world.GetPool<Component250>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System104 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component349> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component349>().End();
   _p1 = _world.GetPool<Component349>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System105 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component350> _p1;
EcsPool<Component198> _p2;
EcsPool<Component64> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component350>().Inc<Component198>().Inc<Component64>().End();
   _p1 = _world.GetPool<Component350>();
   _p2 = _world.GetPool<Component198>();
   _p3 = _world.GetPool<Component64>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System106 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component8> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component8>().End();
   _p1 = _world.GetPool<Component8>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System107 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component6> _p1;
EcsPool<Component230> _p2;
EcsPool<Component95> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component6>().Inc<Component230>().Inc<Component95>().End();
   _p1 = _world.GetPool<Component6>();
   _p2 = _world.GetPool<Component230>();
   _p3 = _world.GetPool<Component95>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System108 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component435> _p1;
EcsPool<Component61> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component435>().Inc<Component61>().End();
   _p1 = _world.GetPool<Component435>();
   _p2 = _world.GetPool<Component61>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System109 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component61> _p1;
EcsPool<Component337> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component61>().Inc<Component337>().End();
   _p1 = _world.GetPool<Component61>();
   _p2 = _world.GetPool<Component337>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System110 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component290> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component290>().End();
   _p1 = _world.GetPool<Component290>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System111 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component95> _p1;
EcsPool<Component199> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component95>().Inc<Component199>().End();
   _p1 = _world.GetPool<Component95>();
   _p2 = _world.GetPool<Component199>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System112 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component73> _p1;
EcsPool<Component191> _p2;
EcsPool<Component68> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component73>().Inc<Component191>().Inc<Component68>().End();
   _p1 = _world.GetPool<Component73>();
   _p2 = _world.GetPool<Component191>();
   _p3 = _world.GetPool<Component68>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System113 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component418> _p1;
EcsPool<Component72> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component418>().Inc<Component72>().End();
   _p1 = _world.GetPool<Component418>();
   _p2 = _world.GetPool<Component72>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System114 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component42> _p1;
EcsPool<Component233> _p2;
EcsPool<Component50> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component42>().Inc<Component233>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component42>();
   _p2 = _world.GetPool<Component233>();
   _p3 = _world.GetPool<Component50>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System115 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component441> _p1;
EcsPool<Component458> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component441>().Inc<Component458>().End();
   _p1 = _world.GetPool<Component441>();
   _p2 = _world.GetPool<Component458>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System116 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component264> _p1;
EcsPool<Component165> _p2;
EcsPool<Component473> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component264>().Inc<Component165>().Inc<Component473>().End();
   _p1 = _world.GetPool<Component264>();
   _p2 = _world.GetPool<Component165>();
   _p3 = _world.GetPool<Component473>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System117 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component434> _p1;
EcsPool<Component274> _p2;
EcsPool<Component117> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component434>().Inc<Component274>().Inc<Component117>().End();
   _p1 = _world.GetPool<Component434>();
   _p2 = _world.GetPool<Component274>();
   _p3 = _world.GetPool<Component117>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System118 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component174> _p1;
EcsPool<Component308> _p2;
EcsPool<Component418> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component174>().Inc<Component308>().Inc<Component418>().End();
   _p1 = _world.GetPool<Component174>();
   _p2 = _world.GetPool<Component308>();
   _p3 = _world.GetPool<Component418>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System119 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component432> _p1;
EcsPool<Component283> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component432>().Inc<Component283>().End();
   _p1 = _world.GetPool<Component432>();
   _p2 = _world.GetPool<Component283>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System120 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component288> _p1;
EcsPool<Component81> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component288>().Inc<Component81>().End();
   _p1 = _world.GetPool<Component288>();
   _p2 = _world.GetPool<Component81>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System121 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component150> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component150>().End();
   _p1 = _world.GetPool<Component150>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System122 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component277> _p1;
EcsPool<Component6> _p2;
EcsPool<Component495> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component277>().Inc<Component6>().Inc<Component495>().End();
   _p1 = _world.GetPool<Component277>();
   _p2 = _world.GetPool<Component6>();
   _p3 = _world.GetPool<Component495>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System123 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component90> _p1;
EcsPool<Component312> _p2;
EcsPool<Component102> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component90>().Inc<Component312>().Inc<Component102>().End();
   _p1 = _world.GetPool<Component90>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component102>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System124 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component362> _p1;
EcsPool<Component135> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component362>().Inc<Component135>().End();
   _p1 = _world.GetPool<Component362>();
   _p2 = _world.GetPool<Component135>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System125 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component119> _p1;
EcsPool<Component314> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component119>().Inc<Component314>().End();
   _p1 = _world.GetPool<Component119>();
   _p2 = _world.GetPool<Component314>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System126 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component73> _p1;
EcsPool<Component348> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component73>().Inc<Component348>().End();
   _p1 = _world.GetPool<Component73>();
   _p2 = _world.GetPool<Component348>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System127 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component294> _p1;
EcsPool<Component160> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component294>().Inc<Component160>().End();
   _p1 = _world.GetPool<Component294>();
   _p2 = _world.GetPool<Component160>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System128 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component290> _p1;
EcsPool<Component230> _p2;
EcsPool<Component16> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component290>().Inc<Component230>().Inc<Component16>().End();
   _p1 = _world.GetPool<Component290>();
   _p2 = _world.GetPool<Component230>();
   _p3 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System129 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component258> _p1;
EcsPool<Component119> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component258>().Inc<Component119>().End();
   _p1 = _world.GetPool<Component258>();
   _p2 = _world.GetPool<Component119>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System130 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component120> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component120>().End();
   _p1 = _world.GetPool<Component120>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System131 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component444> _p1;
EcsPool<Component468> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component444>().Inc<Component468>().End();
   _p1 = _world.GetPool<Component444>();
   _p2 = _world.GetPool<Component468>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System132 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component290> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component290>().End();
   _p1 = _world.GetPool<Component290>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System133 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component61> _p1;
EcsPool<Component257> _p2;
EcsPool<Component169> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component61>().Inc<Component257>().Inc<Component169>().End();
   _p1 = _world.GetPool<Component61>();
   _p2 = _world.GetPool<Component257>();
   _p3 = _world.GetPool<Component169>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System134 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component283> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component283>().End();
   _p1 = _world.GetPool<Component283>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System135 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component171> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component171>().End();
   _p1 = _world.GetPool<Component171>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System136 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component480> _p1;
EcsPool<Component39> _p2;
EcsPool<Component65> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component480>().Inc<Component39>().Inc<Component65>().End();
   _p1 = _world.GetPool<Component480>();
   _p2 = _world.GetPool<Component39>();
   _p3 = _world.GetPool<Component65>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System137 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component483> _p1;
EcsPool<Component209> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component483>().Inc<Component209>().End();
   _p1 = _world.GetPool<Component483>();
   _p2 = _world.GetPool<Component209>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System138 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component376> _p1;
EcsPool<Component471> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component376>().Inc<Component471>().End();
   _p1 = _world.GetPool<Component376>();
   _p2 = _world.GetPool<Component471>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System139 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component403> _p1;
EcsPool<Component225> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component403>().Inc<Component225>().End();
   _p1 = _world.GetPool<Component403>();
   _p2 = _world.GetPool<Component225>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System140 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component47> _p1;
EcsPool<Component490> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component47>().Inc<Component490>().End();
   _p1 = _world.GetPool<Component47>();
   _p2 = _world.GetPool<Component490>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System141 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component157> _p1;
EcsPool<Component470> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component157>().Inc<Component470>().End();
   _p1 = _world.GetPool<Component157>();
   _p2 = _world.GetPool<Component470>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System142 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component481> _p1;
EcsPool<Component368> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component481>().Inc<Component368>().End();
   _p1 = _world.GetPool<Component481>();
   _p2 = _world.GetPool<Component368>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System143 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component167> _p1;
EcsPool<Component114> _p2;
EcsPool<Component329> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component167>().Inc<Component114>().Inc<Component329>().End();
   _p1 = _world.GetPool<Component167>();
   _p2 = _world.GetPool<Component114>();
   _p3 = _world.GetPool<Component329>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System144 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component161> _p1;
EcsPool<Component315> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component161>().Inc<Component315>().End();
   _p1 = _world.GetPool<Component161>();
   _p2 = _world.GetPool<Component315>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System145 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component259> _p1;
EcsPool<Component11> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component259>().Inc<Component11>().End();
   _p1 = _world.GetPool<Component259>();
   _p2 = _world.GetPool<Component11>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System146 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component253> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component253>().End();
   _p1 = _world.GetPool<Component253>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System147 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component250> _p1;
EcsPool<Component477> _p2;
EcsPool<Component193> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component250>().Inc<Component477>().Inc<Component193>().End();
   _p1 = _world.GetPool<Component250>();
   _p2 = _world.GetPool<Component477>();
   _p3 = _world.GetPool<Component193>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System148 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component135> _p1;
EcsPool<Component430> _p2;
EcsPool<Component411> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component135>().Inc<Component430>().Inc<Component411>().End();
   _p1 = _world.GetPool<Component135>();
   _p2 = _world.GetPool<Component430>();
   _p3 = _world.GetPool<Component411>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System149 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component472> _p1;
EcsPool<Component181> _p2;
EcsPool<Component225> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component472>().Inc<Component181>().Inc<Component225>().End();
   _p1 = _world.GetPool<Component472>();
   _p2 = _world.GetPool<Component181>();
   _p3 = _world.GetPool<Component225>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System150 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component330> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component330>().End();
   _p1 = _world.GetPool<Component330>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System151 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component267> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component267>().End();
   _p1 = _world.GetPool<Component267>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System152 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component399> _p1;
EcsPool<Component312> _p2;
EcsPool<Component448> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component399>().Inc<Component312>().Inc<Component448>().End();
   _p1 = _world.GetPool<Component399>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component448>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System153 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component61> _p1;
EcsPool<Component62> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component61>().Inc<Component62>().End();
   _p1 = _world.GetPool<Component61>();
   _p2 = _world.GetPool<Component62>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System154 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component450> _p1;
EcsPool<Component469> _p2;
EcsPool<Component167> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component450>().Inc<Component469>().Inc<Component167>().End();
   _p1 = _world.GetPool<Component450>();
   _p2 = _world.GetPool<Component469>();
   _p3 = _world.GetPool<Component167>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System155 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component393> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component393>().End();
   _p1 = _world.GetPool<Component393>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System156 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component211> _p1;
EcsPool<Component276> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component211>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component211>();
   _p2 = _world.GetPool<Component276>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System157 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component472> _p1;
EcsPool<Component308> _p2;
EcsPool<Component297> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component472>().Inc<Component308>().Inc<Component297>().End();
   _p1 = _world.GetPool<Component472>();
   _p2 = _world.GetPool<Component308>();
   _p3 = _world.GetPool<Component297>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System158 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component42> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component42>().End();
   _p1 = _world.GetPool<Component42>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System159 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component335> _p1;
EcsPool<Component242> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component335>().Inc<Component242>().End();
   _p1 = _world.GetPool<Component335>();
   _p2 = _world.GetPool<Component242>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System160 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component426> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component426>().End();
   _p1 = _world.GetPool<Component426>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System161 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component485> _p1;
EcsPool<Component389> _p2;
EcsPool<Component264> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component485>().Inc<Component389>().Inc<Component264>().End();
   _p1 = _world.GetPool<Component485>();
   _p2 = _world.GetPool<Component389>();
   _p3 = _world.GetPool<Component264>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System162 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component148> _p1;
EcsPool<Component48> _p2;
EcsPool<Component245> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component148>().Inc<Component48>().Inc<Component245>().End();
   _p1 = _world.GetPool<Component148>();
   _p2 = _world.GetPool<Component48>();
   _p3 = _world.GetPool<Component245>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System163 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component198> _p1;
EcsPool<Component89> _p2;
EcsPool<Component63> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component198>().Inc<Component89>().Inc<Component63>().End();
   _p1 = _world.GetPool<Component198>();
   _p2 = _world.GetPool<Component89>();
   _p3 = _world.GetPool<Component63>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System164 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component187> _p1;
EcsPool<Component105> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component187>().Inc<Component105>().End();
   _p1 = _world.GetPool<Component187>();
   _p2 = _world.GetPool<Component105>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System165 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component489> _p1;
EcsPool<Component467> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component489>().Inc<Component467>().End();
   _p1 = _world.GetPool<Component489>();
   _p2 = _world.GetPool<Component467>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System166 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component17> _p1;
EcsPool<Component244> _p2;
EcsPool<Component260> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component17>().Inc<Component244>().Inc<Component260>().End();
   _p1 = _world.GetPool<Component17>();
   _p2 = _world.GetPool<Component244>();
   _p3 = _world.GetPool<Component260>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System167 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component361> _p1;
EcsPool<Component92> _p2;
EcsPool<Component22> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component361>().Inc<Component92>().Inc<Component22>().End();
   _p1 = _world.GetPool<Component361>();
   _p2 = _world.GetPool<Component92>();
   _p3 = _world.GetPool<Component22>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System168 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component254> _p1;
EcsPool<Component390> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component254>().Inc<Component390>().End();
   _p1 = _world.GetPool<Component254>();
   _p2 = _world.GetPool<Component390>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System169 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component477> _p1;
EcsPool<Component206> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component477>().Inc<Component206>().End();
   _p1 = _world.GetPool<Component477>();
   _p2 = _world.GetPool<Component206>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System170 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component134> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component134>().End();
   _p1 = _world.GetPool<Component134>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System171 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component385> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component385>().End();
   _p1 = _world.GetPool<Component385>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System172 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component205> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component205>().End();
   _p1 = _world.GetPool<Component205>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System173 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component399> _p1;
EcsPool<Component345> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component399>().Inc<Component345>().End();
   _p1 = _world.GetPool<Component399>();
   _p2 = _world.GetPool<Component345>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System174 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component351> _p1;
EcsPool<Component77> _p2;
EcsPool<Component274> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component351>().Inc<Component77>().Inc<Component274>().End();
   _p1 = _world.GetPool<Component351>();
   _p2 = _world.GetPool<Component77>();
   _p3 = _world.GetPool<Component274>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System175 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component8> _p1;
EcsPool<Component109> _p2;
EcsPool<Component407> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component8>().Inc<Component109>().Inc<Component407>().End();
   _p1 = _world.GetPool<Component8>();
   _p2 = _world.GetPool<Component109>();
   _p3 = _world.GetPool<Component407>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System176 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component208> _p1;
EcsPool<Component367> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component208>().Inc<Component367>().End();
   _p1 = _world.GetPool<Component208>();
   _p2 = _world.GetPool<Component367>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System177 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component53> _p1;
EcsPool<Component181> _p2;
EcsPool<Component185> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component53>().Inc<Component181>().Inc<Component185>().End();
   _p1 = _world.GetPool<Component53>();
   _p2 = _world.GetPool<Component181>();
   _p3 = _world.GetPool<Component185>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System178 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component28> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component28>().End();
   _p1 = _world.GetPool<Component28>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System179 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component463> _p1;
EcsPool<Component431> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component463>().Inc<Component431>().End();
   _p1 = _world.GetPool<Component463>();
   _p2 = _world.GetPool<Component431>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System180 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component355> _p1;
EcsPool<Component159> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component355>().Inc<Component159>().End();
   _p1 = _world.GetPool<Component355>();
   _p2 = _world.GetPool<Component159>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System181 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component383> _p1;
EcsPool<Component444> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component383>().Inc<Component444>().End();
   _p1 = _world.GetPool<Component383>();
   _p2 = _world.GetPool<Component444>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System182 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component71> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component71>().End();
   _p1 = _world.GetPool<Component71>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System183 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component182> _p1;
EcsPool<Component284> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component182>().Inc<Component284>().End();
   _p1 = _world.GetPool<Component182>();
   _p2 = _world.GetPool<Component284>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System184 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component482> _p1;
EcsPool<Component171> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component482>().Inc<Component171>().End();
   _p1 = _world.GetPool<Component482>();
   _p2 = _world.GetPool<Component171>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System185 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component408> _p1;
EcsPool<Component327> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component408>().Inc<Component327>().End();
   _p1 = _world.GetPool<Component408>();
   _p2 = _world.GetPool<Component327>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System186 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component184> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component184>().End();
   _p1 = _world.GetPool<Component184>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System187 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component107> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component107>().End();
   _p1 = _world.GetPool<Component107>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System188 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component91> _p1;
EcsPool<Component492> _p2;
EcsPool<Component109> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component91>().Inc<Component492>().Inc<Component109>().End();
   _p1 = _world.GetPool<Component91>();
   _p2 = _world.GetPool<Component492>();
   _p3 = _world.GetPool<Component109>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System189 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component65> _p1;
EcsPool<Component453> _p2;
EcsPool<Component431> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component65>().Inc<Component453>().Inc<Component431>().End();
   _p1 = _world.GetPool<Component65>();
   _p2 = _world.GetPool<Component453>();
   _p3 = _world.GetPool<Component431>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System190 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component32> _p1;
EcsPool<Component33> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component32>().Inc<Component33>().End();
   _p1 = _world.GetPool<Component32>();
   _p2 = _world.GetPool<Component33>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System191 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component468> _p1;
EcsPool<Component50> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component468>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component468>();
   _p2 = _world.GetPool<Component50>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System192 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component192> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component192>().End();
   _p1 = _world.GetPool<Component192>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System193 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component390> _p1;
EcsPool<Component463> _p2;
EcsPool<Component343> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component390>().Inc<Component463>().Inc<Component343>().End();
   _p1 = _world.GetPool<Component390>();
   _p2 = _world.GetPool<Component463>();
   _p3 = _world.GetPool<Component343>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System194 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component187> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component187>().End();
   _p1 = _world.GetPool<Component187>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System195 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component423> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component423>().End();
   _p1 = _world.GetPool<Component423>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System196 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component377> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component377>().End();
   _p1 = _world.GetPool<Component377>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System197 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component388> _p1;
EcsPool<Component276> _p2;
EcsPool<Component253> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component388>().Inc<Component276>().Inc<Component253>().End();
   _p1 = _world.GetPool<Component388>();
   _p2 = _world.GetPool<Component276>();
   _p3 = _world.GetPool<Component253>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System198 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component486> _p1;
EcsPool<Component449> _p2;
EcsPool<Component323> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component486>().Inc<Component449>().Inc<Component323>().End();
   _p1 = _world.GetPool<Component486>();
   _p2 = _world.GetPool<Component449>();
   _p3 = _world.GetPool<Component323>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System199 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component264> _p1;
EcsPool<Component166> _p2;
EcsPool<Component111> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component264>().Inc<Component166>().Inc<Component111>().End();
   _p1 = _world.GetPool<Component264>();
   _p2 = _world.GetPool<Component166>();
   _p3 = _world.GetPool<Component111>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System200 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component378> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component378>().End();
   _p1 = _world.GetPool<Component378>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System201 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component139> _p1;
EcsPool<Component414> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component139>().Inc<Component414>().End();
   _p1 = _world.GetPool<Component139>();
   _p2 = _world.GetPool<Component414>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System202 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component250> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component250>().End();
   _p1 = _world.GetPool<Component250>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System203 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().End();
   _p1 = _world.GetPool<Component13>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System204 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component197> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component197>().End();
   _p1 = _world.GetPool<Component197>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System205 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component470> _p1;
EcsPool<Component196> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component470>().Inc<Component196>().End();
   _p1 = _world.GetPool<Component470>();
   _p2 = _world.GetPool<Component196>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System206 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component170> _p1;
EcsPool<Component69> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component170>().Inc<Component69>().End();
   _p1 = _world.GetPool<Component170>();
   _p2 = _world.GetPool<Component69>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System207 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component474> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component474>().End();
   _p1 = _world.GetPool<Component474>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System208 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component28> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component28>().End();
   _p1 = _world.GetPool<Component28>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System209 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component184> _p1;
EcsPool<Component64> _p2;
EcsPool<Component155> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component184>().Inc<Component64>().Inc<Component155>().End();
   _p1 = _world.GetPool<Component184>();
   _p2 = _world.GetPool<Component64>();
   _p3 = _world.GetPool<Component155>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System210 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component90> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component90>().End();
   _p1 = _world.GetPool<Component90>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System211 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component268> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component268>().End();
   _p1 = _world.GetPool<Component268>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System212 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component102> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component102>().End();
   _p1 = _world.GetPool<Component102>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System213 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component25> _p1;
EcsPool<Component245> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component25>().Inc<Component245>().End();
   _p1 = _world.GetPool<Component25>();
   _p2 = _world.GetPool<Component245>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System214 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component85> _p1;
EcsPool<Component131> _p2;
EcsPool<Component398> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component85>().Inc<Component131>().Inc<Component398>().End();
   _p1 = _world.GetPool<Component85>();
   _p2 = _world.GetPool<Component131>();
   _p3 = _world.GetPool<Component398>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System215 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component465> _p1;
EcsPool<Component172> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component465>().Inc<Component172>().End();
   _p1 = _world.GetPool<Component465>();
   _p2 = _world.GetPool<Component172>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System216 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component364> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component364>().End();
   _p1 = _world.GetPool<Component364>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System217 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component191> _p1;
EcsPool<Component59> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component191>().Inc<Component59>().End();
   _p1 = _world.GetPool<Component191>();
   _p2 = _world.GetPool<Component59>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System218 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component266> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component266>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component266>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System219 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component254> _p1;
EcsPool<Component288> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component254>().Inc<Component288>().End();
   _p1 = _world.GetPool<Component254>();
   _p2 = _world.GetPool<Component288>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System220 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component98> _p1;
EcsPool<Component82> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component98>().Inc<Component82>().End();
   _p1 = _world.GetPool<Component98>();
   _p2 = _world.GetPool<Component82>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System221 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component194> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component194>().End();
   _p1 = _world.GetPool<Component194>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System222 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component484> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component484>().End();
   _p1 = _world.GetPool<Component484>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System223 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component60> _p1;
EcsPool<Component203> _p2;
EcsPool<Component299> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component60>().Inc<Component203>().Inc<Component299>().End();
   _p1 = _world.GetPool<Component60>();
   _p2 = _world.GetPool<Component203>();
   _p3 = _world.GetPool<Component299>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System224 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component19> _p1;
EcsPool<Component365> _p2;
EcsPool<Component190> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component19>().Inc<Component365>().Inc<Component190>().End();
   _p1 = _world.GetPool<Component19>();
   _p2 = _world.GetPool<Component365>();
   _p3 = _world.GetPool<Component190>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System225 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component343> _p1;
EcsPool<Component135> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component343>().Inc<Component135>().End();
   _p1 = _world.GetPool<Component343>();
   _p2 = _world.GetPool<Component135>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System226 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component171> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component171>().End();
   _p1 = _world.GetPool<Component171>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System227 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component9> _p1;
EcsPool<Component395> _p2;
EcsPool<Component14> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component9>().Inc<Component395>().Inc<Component14>().End();
   _p1 = _world.GetPool<Component9>();
   _p2 = _world.GetPool<Component395>();
   _p3 = _world.GetPool<Component14>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System228 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component424> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component424>().End();
   _p1 = _world.GetPool<Component424>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System229 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component95> _p1;
EcsPool<Component267> _p2;
EcsPool<Component345> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component95>().Inc<Component267>().Inc<Component345>().End();
   _p1 = _world.GetPool<Component95>();
   _p2 = _world.GetPool<Component267>();
   _p3 = _world.GetPool<Component345>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System230 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component488> _p1;
EcsPool<Component390> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component488>().Inc<Component390>().End();
   _p1 = _world.GetPool<Component488>();
   _p2 = _world.GetPool<Component390>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System231 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component42> _p1;
EcsPool<Component427> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component42>().Inc<Component427>().End();
   _p1 = _world.GetPool<Component42>();
   _p2 = _world.GetPool<Component427>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System232 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component282> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component282>().End();
   _p1 = _world.GetPool<Component282>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System233 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component484> _p1;
EcsPool<Component414> _p2;
EcsPool<Component408> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component484>().Inc<Component414>().Inc<Component408>().End();
   _p1 = _world.GetPool<Component484>();
   _p2 = _world.GetPool<Component414>();
   _p3 = _world.GetPool<Component408>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System234 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component468> _p1;
EcsPool<Component214> _p2;
EcsPool<Component494> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component468>().Inc<Component214>().Inc<Component494>().End();
   _p1 = _world.GetPool<Component468>();
   _p2 = _world.GetPool<Component214>();
   _p3 = _world.GetPool<Component494>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System235 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component325> _p1;
EcsPool<Component368> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component325>().Inc<Component368>().End();
   _p1 = _world.GetPool<Component325>();
   _p2 = _world.GetPool<Component368>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System236 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component401> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component401>().End();
   _p1 = _world.GetPool<Component401>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System237 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component241> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component241>().End();
   _p1 = _world.GetPool<Component241>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System238 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().End();
   _p1 = _world.GetPool<Component402>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System239 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component202> _p1;
EcsPool<Component68> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component202>().Inc<Component68>().End();
   _p1 = _world.GetPool<Component202>();
   _p2 = _world.GetPool<Component68>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System240 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component270> _p1;
EcsPool<Component273> _p2;
EcsPool<Component388> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component270>().Inc<Component273>().Inc<Component388>().End();
   _p1 = _world.GetPool<Component270>();
   _p2 = _world.GetPool<Component273>();
   _p3 = _world.GetPool<Component388>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System241 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component214> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component214>().End();
   _p1 = _world.GetPool<Component214>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System242 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component311> _p1;
EcsPool<Component478> _p2;
EcsPool<Component205> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component311>().Inc<Component478>().Inc<Component205>().End();
   _p1 = _world.GetPool<Component311>();
   _p2 = _world.GetPool<Component478>();
   _p3 = _world.GetPool<Component205>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System243 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component263> _p1;
EcsPool<Component61> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component263>().Inc<Component61>().End();
   _p1 = _world.GetPool<Component263>();
   _p2 = _world.GetPool<Component61>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System244 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component244> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component244>().End();
   _p1 = _world.GetPool<Component244>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System245 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component256> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component256>().End();
   _p1 = _world.GetPool<Component256>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System246 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component103> _p1;
EcsPool<Component426> _p2;
EcsPool<Component300> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component103>().Inc<Component426>().Inc<Component300>().End();
   _p1 = _world.GetPool<Component103>();
   _p2 = _world.GetPool<Component426>();
   _p3 = _world.GetPool<Component300>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System247 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component183> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component183>().End();
   _p1 = _world.GetPool<Component183>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System248 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component226> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component226>().End();
   _p1 = _world.GetPool<Component226>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System249 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component443> _p1;
EcsPool<Component149> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component443>().Inc<Component149>().End();
   _p1 = _world.GetPool<Component443>();
   _p2 = _world.GetPool<Component149>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System250 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component307> _p1;
EcsPool<Component411> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component307>().Inc<Component411>().End();
   _p1 = _world.GetPool<Component307>();
   _p2 = _world.GetPool<Component411>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System251 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component94> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().Inc<Component94>().End();
   _p1 = _world.GetPool<Component224>();
   _p2 = _world.GetPool<Component94>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System252 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component120> _p1;
EcsPool<Component211> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component120>().Inc<Component211>().End();
   _p1 = _world.GetPool<Component120>();
   _p2 = _world.GetPool<Component211>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System253 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component311> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component311>().End();
   _p1 = _world.GetPool<Component311>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System254 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component45> _p1;
EcsPool<Component403> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component45>().Inc<Component403>().End();
   _p1 = _world.GetPool<Component45>();
   _p2 = _world.GetPool<Component403>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System255 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component35> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component35>().End();
   _p1 = _world.GetPool<Component35>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System256 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component105> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component105>().End();
   _p1 = _world.GetPool<Component105>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System257 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component340> _p1;
EcsPool<Component386> _p2;
EcsPool<Component188> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component340>().Inc<Component386>().Inc<Component188>().End();
   _p1 = _world.GetPool<Component340>();
   _p2 = _world.GetPool<Component386>();
   _p3 = _world.GetPool<Component188>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System258 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component423> _p1;
EcsPool<Component176> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component423>().Inc<Component176>().End();
   _p1 = _world.GetPool<Component423>();
   _p2 = _world.GetPool<Component176>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System259 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component267> _p1;
EcsPool<Component356> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component267>().Inc<Component356>().End();
   _p1 = _world.GetPool<Component267>();
   _p2 = _world.GetPool<Component356>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System260 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().End();
   _p1 = _world.GetPool<Component224>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System261 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component387> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component387>().End();
   _p1 = _world.GetPool<Component387>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System262 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component273> _p1;
EcsPool<Component64> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component273>().Inc<Component64>().End();
   _p1 = _world.GetPool<Component273>();
   _p2 = _world.GetPool<Component64>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System263 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component293> _p1;
EcsPool<Component60> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component293>().Inc<Component60>().End();
   _p1 = _world.GetPool<Component293>();
   _p2 = _world.GetPool<Component60>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System264 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component466> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component466>().End();
   _p1 = _world.GetPool<Component466>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System265 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component123> _p1;
EcsPool<Component341> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component123>().Inc<Component341>().End();
   _p1 = _world.GetPool<Component123>();
   _p2 = _world.GetPool<Component341>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System266 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component166> _p1;
EcsPool<Component412> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component166>().Inc<Component412>().End();
   _p1 = _world.GetPool<Component166>();
   _p2 = _world.GetPool<Component412>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System267 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component397> _p1;
EcsPool<Component92> _p2;
EcsPool<Component147> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component397>().Inc<Component92>().Inc<Component147>().End();
   _p1 = _world.GetPool<Component397>();
   _p2 = _world.GetPool<Component92>();
   _p3 = _world.GetPool<Component147>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System268 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component121> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component121>().End();
   _p1 = _world.GetPool<Component121>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System269 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component102> _p1;
EcsPool<Component263> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component102>().Inc<Component263>().End();
   _p1 = _world.GetPool<Component102>();
   _p2 = _world.GetPool<Component263>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System270 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component481> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component481>().End();
   _p1 = _world.GetPool<Component481>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System271 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component85> _p1;
EcsPool<Component448> _p2;
EcsPool<Component327> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component85>().Inc<Component448>().Inc<Component327>().End();
   _p1 = _world.GetPool<Component85>();
   _p2 = _world.GetPool<Component448>();
   _p3 = _world.GetPool<Component327>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System272 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component34> _p1;
EcsPool<Component487> _p2;
EcsPool<Component363> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component34>().Inc<Component487>().Inc<Component363>().End();
   _p1 = _world.GetPool<Component34>();
   _p2 = _world.GetPool<Component487>();
   _p3 = _world.GetPool<Component363>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System273 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component419> _p1;
EcsPool<Component272> _p2;
EcsPool<Component338> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component419>().Inc<Component272>().Inc<Component338>().End();
   _p1 = _world.GetPool<Component419>();
   _p2 = _world.GetPool<Component272>();
   _p3 = _world.GetPool<Component338>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System274 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component242> _p1;
EcsPool<Component442> _p2;
EcsPool<Component66> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component242>().Inc<Component442>().Inc<Component66>().End();
   _p1 = _world.GetPool<Component242>();
   _p2 = _world.GetPool<Component442>();
   _p3 = _world.GetPool<Component66>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System275 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component96> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component96>().End();
   _p1 = _world.GetPool<Component96>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System276 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component347> _p1;
EcsPool<Component94> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component347>().Inc<Component94>().End();
   _p1 = _world.GetPool<Component347>();
   _p2 = _world.GetPool<Component94>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System277 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component264> _p1;
EcsPool<Component395> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component264>().Inc<Component395>().End();
   _p1 = _world.GetPool<Component264>();
   _p2 = _world.GetPool<Component395>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System278 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component264> _p1;
EcsPool<Component439> _p2;
EcsPool<Component179> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component264>().Inc<Component439>().Inc<Component179>().End();
   _p1 = _world.GetPool<Component264>();
   _p2 = _world.GetPool<Component439>();
   _p3 = _world.GetPool<Component179>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System279 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component176> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component176>().End();
   _p1 = _world.GetPool<Component176>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System280 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component9> _p1;
EcsPool<Component6> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component9>().Inc<Component6>().End();
   _p1 = _world.GetPool<Component9>();
   _p2 = _world.GetPool<Component6>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System281 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component305> _p1;
EcsPool<Component474> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component305>().Inc<Component474>().End();
   _p1 = _world.GetPool<Component305>();
   _p2 = _world.GetPool<Component474>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System282 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component139> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component139>().End();
   _p1 = _world.GetPool<Component139>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System283 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component89> _p1;
EcsPool<Component354> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component89>().Inc<Component354>().End();
   _p1 = _world.GetPool<Component89>();
   _p2 = _world.GetPool<Component354>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System284 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component242> _p1;
EcsPool<Component493> _p2;
EcsPool<Component107> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component242>().Inc<Component493>().Inc<Component107>().End();
   _p1 = _world.GetPool<Component242>();
   _p2 = _world.GetPool<Component493>();
   _p3 = _world.GetPool<Component107>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System285 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component247> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component247>().End();
   _p1 = _world.GetPool<Component247>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System286 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component103> _p1;
EcsPool<Component55> _p2;
EcsPool<Component181> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component103>().Inc<Component55>().Inc<Component181>().End();
   _p1 = _world.GetPool<Component103>();
   _p2 = _world.GetPool<Component55>();
   _p3 = _world.GetPool<Component181>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System287 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component0> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component0>().End();
   _p1 = _world.GetPool<Component0>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System288 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component386> _p1;
EcsPool<Component230> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component386>().Inc<Component230>().End();
   _p1 = _world.GetPool<Component386>();
   _p2 = _world.GetPool<Component230>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System289 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component52> _p1;
EcsPool<Component457> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component52>().Inc<Component457>().End();
   _p1 = _world.GetPool<Component52>();
   _p2 = _world.GetPool<Component457>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System290 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component94> _p1;
EcsPool<Component307> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component94>().Inc<Component307>().End();
   _p1 = _world.GetPool<Component94>();
   _p2 = _world.GetPool<Component307>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System291 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component248> _p1;
EcsPool<Component251> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component248>().Inc<Component251>().End();
   _p1 = _world.GetPool<Component248>();
   _p2 = _world.GetPool<Component251>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System292 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component332> _p1;
EcsPool<Component154> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component332>().Inc<Component154>().End();
   _p1 = _world.GetPool<Component332>();
   _p2 = _world.GetPool<Component154>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System293 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component467> _p1;
EcsPool<Component474> _p2;
EcsPool<Component390> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component467>().Inc<Component474>().Inc<Component390>().End();
   _p1 = _world.GetPool<Component467>();
   _p2 = _world.GetPool<Component474>();
   _p3 = _world.GetPool<Component390>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System294 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component173> _p1;
EcsPool<Component492> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component173>().Inc<Component492>().End();
   _p1 = _world.GetPool<Component173>();
   _p2 = _world.GetPool<Component492>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System295 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component15> _p1;
EcsPool<Component271> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component15>().Inc<Component271>().End();
   _p1 = _world.GetPool<Component15>();
   _p2 = _world.GetPool<Component271>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System296 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component311> _p1;
EcsPool<Component16> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component311>().Inc<Component16>().End();
   _p1 = _world.GetPool<Component311>();
   _p2 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System297 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component76> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component76>().End();
   _p1 = _world.GetPool<Component76>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System298 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component494> _p1;
EcsPool<Component162> _p2;
EcsPool<Component9> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component494>().Inc<Component162>().Inc<Component9>().End();
   _p1 = _world.GetPool<Component494>();
   _p2 = _world.GetPool<Component162>();
   _p3 = _world.GetPool<Component9>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System299 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component304> _p1;
EcsPool<Component75> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component304>().Inc<Component75>().End();
   _p1 = _world.GetPool<Component304>();
   _p2 = _world.GetPool<Component75>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System300 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component38> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component38>().End();
   _p1 = _world.GetPool<Component38>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System301 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component88> _p1;
EcsPool<Component494> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component88>().Inc<Component494>().End();
   _p1 = _world.GetPool<Component88>();
   _p2 = _world.GetPool<Component494>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System302 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component43> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component43>().End();
   _p1 = _world.GetPool<Component43>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System303 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component241> _p1;
EcsPool<Component344> _p2;
EcsPool<Component226> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component241>().Inc<Component344>().Inc<Component226>().End();
   _p1 = _world.GetPool<Component241>();
   _p2 = _world.GetPool<Component344>();
   _p3 = _world.GetPool<Component226>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System304 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component469> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component469>().End();
   _p1 = _world.GetPool<Component469>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System305 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component80> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component80>().End();
   _p1 = _world.GetPool<Component80>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System306 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component193> _p1;
EcsPool<Component326> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component193>().Inc<Component326>().End();
   _p1 = _world.GetPool<Component193>();
   _p2 = _world.GetPool<Component326>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System307 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component158> _p1;
EcsPool<Component214> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component158>().Inc<Component214>().End();
   _p1 = _world.GetPool<Component158>();
   _p2 = _world.GetPool<Component214>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System308 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component264> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component264>().End();
   _p1 = _world.GetPool<Component264>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System309 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component178> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component178>().End();
   _p1 = _world.GetPool<Component178>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System310 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component231> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component231>().End();
   _p1 = _world.GetPool<Component231>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System311 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component253> _p1;
EcsPool<Component88> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component253>().Inc<Component88>().End();
   _p1 = _world.GetPool<Component253>();
   _p2 = _world.GetPool<Component88>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System312 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component350> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component350>().End();
   _p1 = _world.GetPool<Component350>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System313 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component314> _p1;
EcsPool<Component436> _p2;
EcsPool<Component207> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component314>().Inc<Component436>().Inc<Component207>().End();
   _p1 = _world.GetPool<Component314>();
   _p2 = _world.GetPool<Component436>();
   _p3 = _world.GetPool<Component207>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System314 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component179> _p1;
EcsPool<Component446> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component179>().Inc<Component446>().End();
   _p1 = _world.GetPool<Component179>();
   _p2 = _world.GetPool<Component446>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System315 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component21> _p1;
EcsPool<Component29> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component21>().Inc<Component29>().End();
   _p1 = _world.GetPool<Component21>();
   _p2 = _world.GetPool<Component29>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System316 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component85> _p1;
EcsPool<Component424> _p2;
EcsPool<Component65> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component85>().Inc<Component424>().Inc<Component65>().End();
   _p1 = _world.GetPool<Component85>();
   _p2 = _world.GetPool<Component424>();
   _p3 = _world.GetPool<Component65>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System317 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component404> _p1;
EcsPool<Component202> _p2;
EcsPool<Component468> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component404>().Inc<Component202>().Inc<Component468>().End();
   _p1 = _world.GetPool<Component404>();
   _p2 = _world.GetPool<Component202>();
   _p3 = _world.GetPool<Component468>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System318 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component76> _p1;
EcsPool<Component145> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component76>().Inc<Component145>().End();
   _p1 = _world.GetPool<Component76>();
   _p2 = _world.GetPool<Component145>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System319 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component103> _p1;
EcsPool<Component274> _p2;
EcsPool<Component37> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component103>().Inc<Component274>().Inc<Component37>().End();
   _p1 = _world.GetPool<Component103>();
   _p2 = _world.GetPool<Component274>();
   _p3 = _world.GetPool<Component37>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System320 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component434> _p1;
EcsPool<Component315> _p2;
EcsPool<Component205> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component434>().Inc<Component315>().Inc<Component205>().End();
   _p1 = _world.GetPool<Component434>();
   _p2 = _world.GetPool<Component315>();
   _p3 = _world.GetPool<Component205>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System321 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component153> _p1;
EcsPool<Component91> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component153>().Inc<Component91>().End();
   _p1 = _world.GetPool<Component153>();
   _p2 = _world.GetPool<Component91>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System322 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component241> _p1;
EcsPool<Component108> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component241>().Inc<Component108>().End();
   _p1 = _world.GetPool<Component241>();
   _p2 = _world.GetPool<Component108>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System323 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component144> _p1;
EcsPool<Component83> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component144>().Inc<Component83>().End();
   _p1 = _world.GetPool<Component144>();
   _p2 = _world.GetPool<Component83>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System324 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component146> _p1;
EcsPool<Component271> _p2;
EcsPool<Component474> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component146>().Inc<Component271>().Inc<Component474>().End();
   _p1 = _world.GetPool<Component146>();
   _p2 = _world.GetPool<Component271>();
   _p3 = _world.GetPool<Component474>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System325 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component20> _p1;
EcsPool<Component321> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component20>().Inc<Component321>().End();
   _p1 = _world.GetPool<Component20>();
   _p2 = _world.GetPool<Component321>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System326 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component254> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component254>().End();
   _p1 = _world.GetPool<Component254>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System327 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component290> _p1;
EcsPool<Component433> _p2;
EcsPool<Component50> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component290>().Inc<Component433>().Inc<Component50>().End();
   _p1 = _world.GetPool<Component290>();
   _p2 = _world.GetPool<Component433>();
   _p3 = _world.GetPool<Component50>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System328 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component69> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component69>().End();
   _p1 = _world.GetPool<Component69>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System329 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component205> _p1;
EcsPool<Component499> _p2;
EcsPool<Component211> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component205>().Inc<Component499>().Inc<Component211>().End();
   _p1 = _world.GetPool<Component205>();
   _p2 = _world.GetPool<Component499>();
   _p3 = _world.GetPool<Component211>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System330 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component170> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component170>().End();
   _p1 = _world.GetPool<Component170>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System331 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component131> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component131>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component131>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System332 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component281> _p1;
EcsPool<Component376> _p2;
EcsPool<Component351> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component281>().Inc<Component376>().Inc<Component351>().End();
   _p1 = _world.GetPool<Component281>();
   _p2 = _world.GetPool<Component376>();
   _p3 = _world.GetPool<Component351>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System333 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component182> _p1;
EcsPool<Component456> _p2;
EcsPool<Component120> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component182>().Inc<Component456>().Inc<Component120>().End();
   _p1 = _world.GetPool<Component182>();
   _p2 = _world.GetPool<Component456>();
   _p3 = _world.GetPool<Component120>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System334 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component119> _p1;
EcsPool<Component498> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component119>().Inc<Component498>().End();
   _p1 = _world.GetPool<Component119>();
   _p2 = _world.GetPool<Component498>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System335 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component305> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component305>().End();
   _p1 = _world.GetPool<Component305>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System336 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component168> _p1;
EcsPool<Component82> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component168>().Inc<Component82>().End();
   _p1 = _world.GetPool<Component168>();
   _p2 = _world.GetPool<Component82>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System337 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component476> _p1;
EcsPool<Component155> _p2;
EcsPool<Component438> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component476>().Inc<Component155>().Inc<Component438>().End();
   _p1 = _world.GetPool<Component476>();
   _p2 = _world.GetPool<Component155>();
   _p3 = _world.GetPool<Component438>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System338 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component272> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component272>().End();
   _p1 = _world.GetPool<Component272>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System339 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component32> _p1;
EcsPool<Component21> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component32>().Inc<Component21>().End();
   _p1 = _world.GetPool<Component32>();
   _p2 = _world.GetPool<Component21>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System340 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component36> _p1;
EcsPool<Component108> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component36>().Inc<Component108>().End();
   _p1 = _world.GetPool<Component36>();
   _p2 = _world.GetPool<Component108>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System341 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component482> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component482>().End();
   _p1 = _world.GetPool<Component482>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System342 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component154> _p1;
EcsPool<Component401> _p2;
EcsPool<Component140> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component154>().Inc<Component401>().Inc<Component140>().End();
   _p1 = _world.GetPool<Component154>();
   _p2 = _world.GetPool<Component401>();
   _p3 = _world.GetPool<Component140>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System343 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component411> _p1;
EcsPool<Component144> _p2;
EcsPool<Component470> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component411>().Inc<Component144>().Inc<Component470>().End();
   _p1 = _world.GetPool<Component411>();
   _p2 = _world.GetPool<Component144>();
   _p3 = _world.GetPool<Component470>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System344 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component71> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component71>().End();
   _p1 = _world.GetPool<Component71>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System345 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component170> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component170>().End();
   _p1 = _world.GetPool<Component170>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System346 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component431> _p1;
EcsPool<Component121> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component431>().Inc<Component121>().End();
   _p1 = _world.GetPool<Component431>();
   _p2 = _world.GetPool<Component121>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System347 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component155> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component155>().End();
   _p1 = _world.GetPool<Component155>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System348 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component331> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component331>().End();
   _p1 = _world.GetPool<Component331>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System349 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component210> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component210>().End();
   _p1 = _world.GetPool<Component210>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System350 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component159> _p1;
EcsPool<Component306> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component159>().Inc<Component306>().End();
   _p1 = _world.GetPool<Component159>();
   _p2 = _world.GetPool<Component306>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System351 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component205> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component205>().End();
   _p1 = _world.GetPool<Component205>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System352 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component343> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component343>().End();
   _p1 = _world.GetPool<Component343>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System353 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component167> _p1;
EcsPool<Component146> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component167>().Inc<Component146>().End();
   _p1 = _world.GetPool<Component167>();
   _p2 = _world.GetPool<Component146>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System354 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component10> _p1;
EcsPool<Component278> _p2;
EcsPool<Component206> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component10>().Inc<Component278>().Inc<Component206>().End();
   _p1 = _world.GetPool<Component10>();
   _p2 = _world.GetPool<Component278>();
   _p3 = _world.GetPool<Component206>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System355 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component134> _p1;
EcsPool<Component164> _p2;
EcsPool<Component173> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component134>().Inc<Component164>().Inc<Component173>().End();
   _p1 = _world.GetPool<Component134>();
   _p2 = _world.GetPool<Component164>();
   _p3 = _world.GetPool<Component173>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System356 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component437> _p1;
EcsPool<Component481> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component437>().Inc<Component481>().End();
   _p1 = _world.GetPool<Component437>();
   _p2 = _world.GetPool<Component481>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System357 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component83> _p1;
EcsPool<Component399> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component83>().Inc<Component399>().End();
   _p1 = _world.GetPool<Component83>();
   _p2 = _world.GetPool<Component399>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System358 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component99> _p1;
EcsPool<Component257> _p2;
EcsPool<Component410> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component99>().Inc<Component257>().Inc<Component410>().End();
   _p1 = _world.GetPool<Component99>();
   _p2 = _world.GetPool<Component257>();
   _p3 = _world.GetPool<Component410>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System359 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component73> _p1;
EcsPool<Component1> _p2;
EcsPool<Component276> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component73>().Inc<Component1>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component73>();
   _p2 = _world.GetPool<Component1>();
   _p3 = _world.GetPool<Component276>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System360 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component272> _p1;
EcsPool<Component218> _p2;
EcsPool<Component494> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component272>().Inc<Component218>().Inc<Component494>().End();
   _p1 = _world.GetPool<Component272>();
   _p2 = _world.GetPool<Component218>();
   _p3 = _world.GetPool<Component494>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System361 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component34> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component34>().End();
   _p1 = _world.GetPool<Component34>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System362 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component318> _p1;
EcsPool<Component300> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component318>().Inc<Component300>().End();
   _p1 = _world.GetPool<Component318>();
   _p2 = _world.GetPool<Component300>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System363 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component496> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component496>().End();
   _p1 = _world.GetPool<Component496>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System364 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component190> _p1;
EcsPool<Component159> _p2;
EcsPool<Component394> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component190>().Inc<Component159>().Inc<Component394>().End();
   _p1 = _world.GetPool<Component190>();
   _p2 = _world.GetPool<Component159>();
   _p3 = _world.GetPool<Component394>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System365 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component277> _p1;
EcsPool<Component398> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component277>().Inc<Component398>().End();
   _p1 = _world.GetPool<Component277>();
   _p2 = _world.GetPool<Component398>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System366 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component361> _p1;
EcsPool<Component74> _p2;
EcsPool<Component190> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component361>().Inc<Component74>().Inc<Component190>().End();
   _p1 = _world.GetPool<Component361>();
   _p2 = _world.GetPool<Component74>();
   _p3 = _world.GetPool<Component190>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System367 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component380> _p1;
EcsPool<Component76> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component380>().Inc<Component76>().End();
   _p1 = _world.GetPool<Component380>();
   _p2 = _world.GetPool<Component76>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System368 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component251> _p1;
EcsPool<Component106> _p2;
EcsPool<Component335> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component251>().Inc<Component106>().Inc<Component335>().End();
   _p1 = _world.GetPool<Component251>();
   _p2 = _world.GetPool<Component106>();
   _p3 = _world.GetPool<Component335>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System369 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component341> _p1;
EcsPool<Component93> _p2;
EcsPool<Component145> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component341>().Inc<Component93>().Inc<Component145>().End();
   _p1 = _world.GetPool<Component341>();
   _p2 = _world.GetPool<Component93>();
   _p3 = _world.GetPool<Component145>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System370 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component29> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component29>().End();
   _p1 = _world.GetPool<Component29>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System371 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component488> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component488>().End();
   _p1 = _world.GetPool<Component488>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System372 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component38> _p1;
EcsPool<Component130> _p2;
EcsPool<Component382> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component38>().Inc<Component130>().Inc<Component382>().End();
   _p1 = _world.GetPool<Component38>();
   _p2 = _world.GetPool<Component130>();
   _p3 = _world.GetPool<Component382>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System373 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component137> _p1;
EcsPool<Component340> _p2;
EcsPool<Component316> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component137>().Inc<Component340>().Inc<Component316>().End();
   _p1 = _world.GetPool<Component137>();
   _p2 = _world.GetPool<Component340>();
   _p3 = _world.GetPool<Component316>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System374 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component209> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component209>().End();
   _p1 = _world.GetPool<Component209>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System375 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component204> _p1;
EcsPool<Component33> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component204>().Inc<Component33>().End();
   _p1 = _world.GetPool<Component204>();
   _p2 = _world.GetPool<Component33>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System376 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component89> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component89>().End();
   _p1 = _world.GetPool<Component89>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System377 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component139> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component139>().End();
   _p1 = _world.GetPool<Component139>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System378 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component290> _p1;
EcsPool<Component43> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component290>().Inc<Component43>().End();
   _p1 = _world.GetPool<Component290>();
   _p2 = _world.GetPool<Component43>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System379 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component418> _p1;
EcsPool<Component189> _p2;
EcsPool<Component282> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component418>().Inc<Component189>().Inc<Component282>().End();
   _p1 = _world.GetPool<Component418>();
   _p2 = _world.GetPool<Component189>();
   _p3 = _world.GetPool<Component282>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System380 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component483> _p1;
EcsPool<Component367> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component483>().Inc<Component367>().End();
   _p1 = _world.GetPool<Component483>();
   _p2 = _world.GetPool<Component367>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System381 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component402> _p1;
EcsPool<Component278> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component402>().Inc<Component278>().End();
   _p1 = _world.GetPool<Component402>();
   _p2 = _world.GetPool<Component278>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System382 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component130> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component130>().End();
   _p1 = _world.GetPool<Component130>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System383 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component236> _p1;
EcsPool<Component427> _p2;
EcsPool<Component359> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component236>().Inc<Component427>().Inc<Component359>().End();
   _p1 = _world.GetPool<Component236>();
   _p2 = _world.GetPool<Component427>();
   _p3 = _world.GetPool<Component359>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System384 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component479> _p1;
EcsPool<Component136> _p2;
EcsPool<Component53> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component479>().Inc<Component136>().Inc<Component53>().End();
   _p1 = _world.GetPool<Component479>();
   _p2 = _world.GetPool<Component136>();
   _p3 = _world.GetPool<Component53>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System385 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component64> _p1;
EcsPool<Component417> _p2;
EcsPool<Component196> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component64>().Inc<Component417>().Inc<Component196>().End();
   _p1 = _world.GetPool<Component64>();
   _p2 = _world.GetPool<Component417>();
   _p3 = _world.GetPool<Component196>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System386 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component401> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component401>().End();
   _p1 = _world.GetPool<Component401>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System387 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component299> _p1;
EcsPool<Component252> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component299>().Inc<Component252>().End();
   _p1 = _world.GetPool<Component299>();
   _p2 = _world.GetPool<Component252>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System388 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component6> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component6>().End();
   _p1 = _world.GetPool<Component6>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System389 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component238> _p1;
EcsPool<Component462> _p2;
EcsPool<Component150> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component238>().Inc<Component462>().Inc<Component150>().End();
   _p1 = _world.GetPool<Component238>();
   _p2 = _world.GetPool<Component462>();
   _p3 = _world.GetPool<Component150>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System390 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component349> _p1;
EcsPool<Component347> _p2;
EcsPool<Component197> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component349>().Inc<Component347>().Inc<Component197>().End();
   _p1 = _world.GetPool<Component349>();
   _p2 = _world.GetPool<Component347>();
   _p3 = _world.GetPool<Component197>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System391 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component269> _p1;
EcsPool<Component40> _p2;
EcsPool<Component414> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component269>().Inc<Component40>().Inc<Component414>().End();
   _p1 = _world.GetPool<Component269>();
   _p2 = _world.GetPool<Component40>();
   _p3 = _world.GetPool<Component414>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System392 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component90> _p1;
EcsPool<Component64> _p2;
EcsPool<Component316> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component90>().Inc<Component64>().Inc<Component316>().End();
   _p1 = _world.GetPool<Component90>();
   _p2 = _world.GetPool<Component64>();
   _p3 = _world.GetPool<Component316>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System393 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component205> _p1;
EcsPool<Component229> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component205>().Inc<Component229>().End();
   _p1 = _world.GetPool<Component205>();
   _p2 = _world.GetPool<Component229>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System394 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component160> _p1;
EcsPool<Component65> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component160>().Inc<Component65>().End();
   _p1 = _world.GetPool<Component160>();
   _p2 = _world.GetPool<Component65>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System395 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component155> _p1;
EcsPool<Component273> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component155>().Inc<Component273>().End();
   _p1 = _world.GetPool<Component155>();
   _p2 = _world.GetPool<Component273>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System396 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component492> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component492>().End();
   _p1 = _world.GetPool<Component492>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System397 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component283> _p1;
EcsPool<Component181> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component283>().Inc<Component181>().End();
   _p1 = _world.GetPool<Component283>();
   _p2 = _world.GetPool<Component181>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System398 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component47> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component47>().End();
   _p1 = _world.GetPool<Component47>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System399 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component272> _p1;
EcsPool<Component249> _p2;
EcsPool<Component391> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component272>().Inc<Component249>().Inc<Component391>().End();
   _p1 = _world.GetPool<Component272>();
   _p2 = _world.GetPool<Component249>();
   _p3 = _world.GetPool<Component391>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System400 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component85> _p1;
EcsPool<Component497> _p2;
EcsPool<Component10> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component85>().Inc<Component497>().Inc<Component10>().End();
   _p1 = _world.GetPool<Component85>();
   _p2 = _world.GetPool<Component497>();
   _p3 = _world.GetPool<Component10>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System401 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component281> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component281>().End();
   _p1 = _world.GetPool<Component281>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System402 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component283> _p1;
EcsPool<Component347> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component283>().Inc<Component347>().End();
   _p1 = _world.GetPool<Component283>();
   _p2 = _world.GetPool<Component347>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System403 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component36> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component36>().End();
   _p1 = _world.GetPool<Component36>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System404 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component491> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component491>().End();
   _p1 = _world.GetPool<Component491>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System405 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component5> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component5>().End();
   _p1 = _world.GetPool<Component5>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System406 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component22> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component22>().End();
   _p1 = _world.GetPool<Component22>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System407 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component345> _p1;
EcsPool<Component303> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component345>().Inc<Component303>().End();
   _p1 = _world.GetPool<Component345>();
   _p2 = _world.GetPool<Component303>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System408 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component307> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component307>().End();
   _p1 = _world.GetPool<Component307>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System409 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component428> _p1;
EcsPool<Component357> _p2;
EcsPool<Component120> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component428>().Inc<Component357>().Inc<Component120>().End();
   _p1 = _world.GetPool<Component428>();
   _p2 = _world.GetPool<Component357>();
   _p3 = _world.GetPool<Component120>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System410 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component273> _p1;
EcsPool<Component201> _p2;
EcsPool<Component493> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component273>().Inc<Component201>().Inc<Component493>().End();
   _p1 = _world.GetPool<Component273>();
   _p2 = _world.GetPool<Component201>();
   _p3 = _world.GetPool<Component493>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System411 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component107> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component107>().End();
   _p1 = _world.GetPool<Component107>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System412 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component172> _p1;
EcsPool<Component391> _p2;
EcsPool<Component211> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component172>().Inc<Component391>().Inc<Component211>().End();
   _p1 = _world.GetPool<Component172>();
   _p2 = _world.GetPool<Component391>();
   _p3 = _world.GetPool<Component211>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System413 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component219> _p1;
EcsPool<Component210> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component219>().Inc<Component210>().End();
   _p1 = _world.GetPool<Component219>();
   _p2 = _world.GetPool<Component210>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System414 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component384> _p1;
EcsPool<Component452> _p2;
EcsPool<Component307> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component384>().Inc<Component452>().Inc<Component307>().End();
   _p1 = _world.GetPool<Component384>();
   _p2 = _world.GetPool<Component452>();
   _p3 = _world.GetPool<Component307>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System415 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component465> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component465>().End();
   _p1 = _world.GetPool<Component465>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System416 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component234> _p1;
EcsPool<Component198> _p2;
EcsPool<Component176> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component234>().Inc<Component198>().Inc<Component176>().End();
   _p1 = _world.GetPool<Component234>();
   _p2 = _world.GetPool<Component198>();
   _p3 = _world.GetPool<Component176>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System417 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component104> _p2;
EcsPool<Component427> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().Inc<Component104>().Inc<Component427>().End();
   _p1 = _world.GetPool<Component24>();
   _p2 = _world.GetPool<Component104>();
   _p3 = _world.GetPool<Component427>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System418 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component389> _p1;
EcsPool<Component117> _p2;
EcsPool<Component208> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component389>().Inc<Component117>().Inc<Component208>().End();
   _p1 = _world.GetPool<Component389>();
   _p2 = _world.GetPool<Component117>();
   _p3 = _world.GetPool<Component208>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System419 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component152> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component152>().End();
   _p1 = _world.GetPool<Component152>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System420 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component368> _p1;
EcsPool<Component407> _p2;
EcsPool<Component81> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component368>().Inc<Component407>().Inc<Component81>().End();
   _p1 = _world.GetPool<Component368>();
   _p2 = _world.GetPool<Component407>();
   _p3 = _world.GetPool<Component81>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System421 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component126> _p1;
EcsPool<Component429> _p2;
EcsPool<Component265> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component126>().Inc<Component429>().Inc<Component265>().End();
   _p1 = _world.GetPool<Component126>();
   _p2 = _world.GetPool<Component429>();
   _p3 = _world.GetPool<Component265>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System422 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component193> _p1;
EcsPool<Component293> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component193>().Inc<Component293>().End();
   _p1 = _world.GetPool<Component193>();
   _p2 = _world.GetPool<Component293>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System423 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component302> _p1;
EcsPool<Component77> _p2;
EcsPool<Component466> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component302>().Inc<Component77>().Inc<Component466>().End();
   _p1 = _world.GetPool<Component302>();
   _p2 = _world.GetPool<Component77>();
   _p3 = _world.GetPool<Component466>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System424 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component49> _p1;
EcsPool<Component499> _p2;
EcsPool<Component252> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component49>().Inc<Component499>().Inc<Component252>().End();
   _p1 = _world.GetPool<Component49>();
   _p2 = _world.GetPool<Component499>();
   _p3 = _world.GetPool<Component252>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System425 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component471> _p1;
EcsPool<Component385> _p2;
EcsPool<Component214> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component471>().Inc<Component385>().Inc<Component214>().End();
   _p1 = _world.GetPool<Component471>();
   _p2 = _world.GetPool<Component385>();
   _p3 = _world.GetPool<Component214>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System426 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component227> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component227>().End();
   _p1 = _world.GetPool<Component227>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System427 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component418> _p1;
EcsPool<Component180> _p2;
EcsPool<Component394> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component418>().Inc<Component180>().Inc<Component394>().End();
   _p1 = _world.GetPool<Component418>();
   _p2 = _world.GetPool<Component180>();
   _p3 = _world.GetPool<Component394>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System428 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component273> _p1;
EcsPool<Component2> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component273>().Inc<Component2>().End();
   _p1 = _world.GetPool<Component273>();
   _p2 = _world.GetPool<Component2>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System429 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component66> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component66>().End();
   _p1 = _world.GetPool<Component66>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System430 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component10> _p1;
EcsPool<Component477> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component10>().Inc<Component477>().End();
   _p1 = _world.GetPool<Component10>();
   _p2 = _world.GetPool<Component477>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System431 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component454> _p1;
EcsPool<Component497> _p2;
EcsPool<Component35> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component454>().Inc<Component497>().Inc<Component35>().End();
   _p1 = _world.GetPool<Component454>();
   _p2 = _world.GetPool<Component497>();
   _p3 = _world.GetPool<Component35>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System432 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component415> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component415>().End();
   _p1 = _world.GetPool<Component415>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System433 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component382> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component382>().End();
   _p1 = _world.GetPool<Component382>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System434 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component221> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component221>().End();
   _p1 = _world.GetPool<Component221>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System435 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component460> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component460>().End();
   _p1 = _world.GetPool<Component460>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System436 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component340> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component340>().End();
   _p1 = _world.GetPool<Component340>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System437 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component456> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component456>().End();
   _p1 = _world.GetPool<Component456>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System438 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component181> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component181>().End();
   _p1 = _world.GetPool<Component181>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System439 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component153> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component153>().End();
   _p1 = _world.GetPool<Component153>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System440 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component354> _p1;
EcsPool<Component385> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component354>().Inc<Component385>().End();
   _p1 = _world.GetPool<Component354>();
   _p2 = _world.GetPool<Component385>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System441 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component248> _p1;
EcsPool<Component370> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component248>().Inc<Component370>().End();
   _p1 = _world.GetPool<Component248>();
   _p2 = _world.GetPool<Component370>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System442 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component420> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component420>().End();
   _p1 = _world.GetPool<Component420>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System443 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component236> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component236>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component236>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System444 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component456> _p1;
EcsPool<Component441> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component456>().Inc<Component441>().End();
   _p1 = _world.GetPool<Component456>();
   _p2 = _world.GetPool<Component441>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System445 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component45> _p1;
EcsPool<Component255> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component45>().Inc<Component255>().End();
   _p1 = _world.GetPool<Component45>();
   _p2 = _world.GetPool<Component255>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System446 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component351> _p1;
EcsPool<Component469> _p2;
EcsPool<Component209> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component351>().Inc<Component469>().Inc<Component209>().End();
   _p1 = _world.GetPool<Component351>();
   _p2 = _world.GetPool<Component469>();
   _p3 = _world.GetPool<Component209>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System447 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component138> _p1;
EcsPool<Component246> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component138>().Inc<Component246>().End();
   _p1 = _world.GetPool<Component138>();
   _p2 = _world.GetPool<Component246>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System448 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component219> _p1;
EcsPool<Component367> _p2;
EcsPool<Component443> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component219>().Inc<Component367>().Inc<Component443>().End();
   _p1 = _world.GetPool<Component219>();
   _p2 = _world.GetPool<Component367>();
   _p3 = _world.GetPool<Component443>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System449 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component46> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component46>().End();
   _p1 = _world.GetPool<Component46>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System450 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component385> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component385>().End();
   _p1 = _world.GetPool<Component385>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System451 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component356> _p1;
EcsPool<Component167> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component356>().Inc<Component167>().End();
   _p1 = _world.GetPool<Component356>();
   _p2 = _world.GetPool<Component167>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System452 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component69> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component69>().End();
   _p1 = _world.GetPool<Component69>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System453 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component286> _p1;
EcsPool<Component249> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component286>().Inc<Component249>().End();
   _p1 = _world.GetPool<Component286>();
   _p2 = _world.GetPool<Component249>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System454 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component84> _p1;
EcsPool<Component90> _p2;
EcsPool<Component343> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component84>().Inc<Component90>().Inc<Component343>().End();
   _p1 = _world.GetPool<Component84>();
   _p2 = _world.GetPool<Component90>();
   _p3 = _world.GetPool<Component343>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System455 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component268> _p1;
EcsPool<Component4> _p2;
EcsPool<Component85> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component268>().Inc<Component4>().Inc<Component85>().End();
   _p1 = _world.GetPool<Component268>();
   _p2 = _world.GetPool<Component4>();
   _p3 = _world.GetPool<Component85>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System456 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component72> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component72>().End();
   _p1 = _world.GetPool<Component72>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System457 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component176> _p1;
EcsPool<Component330> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component176>().Inc<Component330>().End();
   _p1 = _world.GetPool<Component176>();
   _p2 = _world.GetPool<Component330>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System458 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component444> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component444>().End();
   _p1 = _world.GetPool<Component444>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System459 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component215> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component215>().End();
   _p1 = _world.GetPool<Component215>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System460 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component315> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component315>().End();
   _p1 = _world.GetPool<Component315>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System461 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component2> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component2>().End();
   _p1 = _world.GetPool<Component2>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System462 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component265> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component265>().End();
   _p1 = _world.GetPool<Component265>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System463 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component210> _p1;
EcsPool<Component350> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component210>().Inc<Component350>().End();
   _p1 = _world.GetPool<Component210>();
   _p2 = _world.GetPool<Component350>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System464 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component99> _p1;
EcsPool<Component274> _p2;
EcsPool<Component161> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component99>().Inc<Component274>().Inc<Component161>().End();
   _p1 = _world.GetPool<Component99>();
   _p2 = _world.GetPool<Component274>();
   _p3 = _world.GetPool<Component161>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System465 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component465> _p1;
EcsPool<Component140> _p2;
EcsPool<Component101> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component465>().Inc<Component140>().Inc<Component101>().End();
   _p1 = _world.GetPool<Component465>();
   _p2 = _world.GetPool<Component140>();
   _p3 = _world.GetPool<Component101>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System466 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component124> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component124>().End();
   _p1 = _world.GetPool<Component124>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System467 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component295> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component295>().End();
   _p1 = _world.GetPool<Component295>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System468 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component123> _p1;
EcsPool<Component215> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component123>().Inc<Component215>().End();
   _p1 = _world.GetPool<Component123>();
   _p2 = _world.GetPool<Component215>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System469 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component281> _p1;
EcsPool<Component82> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component281>().Inc<Component82>().End();
   _p1 = _world.GetPool<Component281>();
   _p2 = _world.GetPool<Component82>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System470 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component358> _p1;
EcsPool<Component55> _p2;
EcsPool<Component276> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component358>().Inc<Component55>().Inc<Component276>().End();
   _p1 = _world.GetPool<Component358>();
   _p2 = _world.GetPool<Component55>();
   _p3 = _world.GetPool<Component276>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System471 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component71> _p1;
EcsPool<Component301> _p2;
EcsPool<Component430> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component71>().Inc<Component301>().Inc<Component430>().End();
   _p1 = _world.GetPool<Component71>();
   _p2 = _world.GetPool<Component301>();
   _p3 = _world.GetPool<Component430>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System472 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component257> _p1;
EcsPool<Component246> _p2;
EcsPool<Component289> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component257>().Inc<Component246>().Inc<Component289>().End();
   _p1 = _world.GetPool<Component257>();
   _p2 = _world.GetPool<Component246>();
   _p3 = _world.GetPool<Component289>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System473 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component344> _p1;
EcsPool<Component133> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component344>().Inc<Component133>().End();
   _p1 = _world.GetPool<Component344>();
   _p2 = _world.GetPool<Component133>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System474 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component321> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component321>().End();
   _p1 = _world.GetPool<Component321>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System475 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component311> _p1;
EcsPool<Component0> _p2;
EcsPool<Component96> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component311>().Inc<Component0>().Inc<Component96>().End();
   _p1 = _world.GetPool<Component311>();
   _p2 = _world.GetPool<Component0>();
   _p3 = _world.GetPool<Component96>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System476 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component36> _p1;
EcsPool<Component228> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component36>().Inc<Component228>().End();
   _p1 = _world.GetPool<Component36>();
   _p2 = _world.GetPool<Component228>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System477 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component319> _p1;
EcsPool<Component471> _p2;
EcsPool<Component419> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component319>().Inc<Component471>().Inc<Component419>().End();
   _p1 = _world.GetPool<Component319>();
   _p2 = _world.GetPool<Component471>();
   _p3 = _world.GetPool<Component419>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System478 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component191> _p1;
EcsPool<Component314> _p2;
EcsPool<Component220> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component191>().Inc<Component314>().Inc<Component220>().End();
   _p1 = _world.GetPool<Component191>();
   _p2 = _world.GetPool<Component314>();
   _p3 = _world.GetPool<Component220>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System479 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component183> _p1;
EcsPool<Component400> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component183>().Inc<Component400>().End();
   _p1 = _world.GetPool<Component183>();
   _p2 = _world.GetPool<Component400>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System480 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component295> _p1;
EcsPool<Component170> _p2;
EcsPool<Component186> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component295>().Inc<Component170>().Inc<Component186>().End();
   _p1 = _world.GetPool<Component295>();
   _p2 = _world.GetPool<Component170>();
   _p3 = _world.GetPool<Component186>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System481 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component360> _p1;
EcsPool<Component45> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component360>().Inc<Component45>().End();
   _p1 = _world.GetPool<Component360>();
   _p2 = _world.GetPool<Component45>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System482 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component383> _p1;
EcsPool<Component354> _p2;
EcsPool<Component300> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component383>().Inc<Component354>().Inc<Component300>().End();
   _p1 = _world.GetPool<Component383>();
   _p2 = _world.GetPool<Component354>();
   _p3 = _world.GetPool<Component300>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component2 = ref _p2.Get(entity);
  }
 }
}

class System483 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component279> _p1;
EcsPool<Component162> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component279>().Inc<Component162>().End();
   _p1 = _world.GetPool<Component279>();
   _p2 = _world.GetPool<Component162>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System484 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component301> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component301>().End();
   _p1 = _world.GetPool<Component301>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System485 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component470> _p1;
EcsPool<Component281> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component470>().Inc<Component281>().End();
   _p1 = _world.GetPool<Component470>();
   _p2 = _world.GetPool<Component281>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System486 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component109> _p1;
EcsPool<Component322> _p2;
EcsPool<Component326> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component109>().Inc<Component322>().Inc<Component326>().End();
   _p1 = _world.GetPool<Component109>();
   _p2 = _world.GetPool<Component322>();
   _p3 = _world.GetPool<Component326>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System487 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component92> _p1;
EcsPool<Component100> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component92>().Inc<Component100>().End();
   _p1 = _world.GetPool<Component92>();
   _p2 = _world.GetPool<Component100>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System488 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component53> _p1;
EcsPool<Component282> _p2;
EcsPool<Component443> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component53>().Inc<Component282>().Inc<Component443>().End();
   _p1 = _world.GetPool<Component53>();
   _p2 = _world.GetPool<Component282>();
   _p3 = _world.GetPool<Component443>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System489 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component479> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component479>().End();
   _p1 = _world.GetPool<Component479>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System490 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component444> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component444>().End();
   _p1 = _world.GetPool<Component444>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System491 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component339> _p1;
EcsPool<Component151> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component339>().Inc<Component151>().End();
   _p1 = _world.GetPool<Component339>();
   _p2 = _world.GetPool<Component151>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System492 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component109> _p1;
EcsPool<Component139> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component109>().Inc<Component139>().End();
   _p1 = _world.GetPool<Component109>();
   _p2 = _world.GetPool<Component139>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System493 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component244> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component244>().End();
   _p1 = _world.GetPool<Component244>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System494 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component373> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component373>().End();
   _p1 = _world.GetPool<Component373>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System495 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component14> _p1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component14>().End();
   _p1 = _world.GetPool<Component14>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   component1.Field0 += 1;
  }
 }
}

class System496 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component257> _p1;
EcsPool<Component251> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component257>().Inc<Component251>().End();
   _p1 = _world.GetPool<Component257>();
   _p2 = _world.GetPool<Component251>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

class System497 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component4> _p1;
EcsPool<Component249> _p2;
EcsPool<Component27> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component4>().Inc<Component249>().Inc<Component27>().End();
   _p1 = _world.GetPool<Component4>();
   _p2 = _world.GetPool<Component249>();
   _p3 = _world.GetPool<Component27>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System498 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component290> _p1;
EcsPool<Component29> _p2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component290>().Inc<Component29>().End();
   _p1 = _world.GetPool<Component290>();
   _p2 = _world.GetPool<Component29>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System499 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component341> _p1;
EcsPool<Component93> _p2;
EcsPool<Component101> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component341>().Inc<Component93>().Inc<Component101>().End();
   _p1 = _world.GetPool<Component341>();
   _p2 = _world.GetPool<Component93>();
   _p3 = _world.GetPool<Component101>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   ref var component1 = ref _p1.Get(entity);
   ref var component2 = ref _p2.Get(entity);
   component1.Field0 += component2.Field0;
  }
 }
}

class System500 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component492> _p1;
EcsPool<Component208> _p2;
EcsPool<Component439> _p3;
EcsPool<Component328> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component492>().Inc<Component208>().Inc<Component439>().End();
   _p1 = _world.GetPool<Component492>();
   _p2 = _world.GetPool<Component208>();
   _p3 = _world.GetPool<Component439>();
   _pl = _world.GetPool<Component328>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System501 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component168> _p1;
EcsPool<Component334> _p2;
EcsPool<Component380> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component168>().Inc<Component334>().End();
   _p1 = _world.GetPool<Component168>();
   _p2 = _world.GetPool<Component334>();
   _pl = _world.GetPool<Component380>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System502 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component150> _p1;
EcsPool<Component90> _p2;
EcsPool<Component361> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component150>().Inc<Component90>().End();
   _p1 = _world.GetPool<Component150>();
   _p2 = _world.GetPool<Component90>();
   _pl = _world.GetPool<Component361>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System503 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component434> _p1;
EcsPool<Component365> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component434>().End();
   _p1 = _world.GetPool<Component434>();
   _pl = _world.GetPool<Component365>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System504 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component452> _p1;
EcsPool<Component182> _p2;
EcsPool<Component78> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component452>().Inc<Component182>().End();
   _p1 = _world.GetPool<Component452>();
   _p2 = _world.GetPool<Component182>();
   _pl = _world.GetPool<Component78>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System505 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component124> _p1;
EcsPool<Component301> _p2;
EcsPool<Component392> _p3;
EcsPool<Component438> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component124>().Inc<Component301>().Inc<Component392>().End();
   _p1 = _world.GetPool<Component124>();
   _p2 = _world.GetPool<Component301>();
   _p3 = _world.GetPool<Component392>();
   _pl = _world.GetPool<Component438>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System506 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component451> _p1;
EcsPool<Component438> _p2;
EcsPool<Component153> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component451>().Inc<Component438>().End();
   _p1 = _world.GetPool<Component451>();
   _p2 = _world.GetPool<Component438>();
   _pl = _world.GetPool<Component153>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System507 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component370> _p1;
EcsPool<Component310> _p2;
EcsPool<Component125> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component370>().Inc<Component310>().End();
   _p1 = _world.GetPool<Component370>();
   _p2 = _world.GetPool<Component310>();
   _pl = _world.GetPool<Component125>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System508 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component160> _p1;
EcsPool<Component58> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component160>().End();
   _p1 = _world.GetPool<Component160>();
   _pl = _world.GetPool<Component58>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System509 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component213> _p1;
EcsPool<Component45> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component213>().End();
   _p1 = _world.GetPool<Component213>();
   _pl = _world.GetPool<Component45>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System510 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component345> _p1;
EcsPool<Component357> _p2;
EcsPool<Component376> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component345>().Inc<Component357>().End();
   _p1 = _world.GetPool<Component345>();
   _p2 = _world.GetPool<Component357>();
   _pl = _world.GetPool<Component376>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System511 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component239> _p1;
EcsPool<Component413> _p2;
EcsPool<Component388> _p3;
EcsPool<Component385> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component239>().Inc<Component413>().Inc<Component388>().End();
   _p1 = _world.GetPool<Component239>();
   _p2 = _world.GetPool<Component413>();
   _p3 = _world.GetPool<Component388>();
   _pl = _world.GetPool<Component385>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System512 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component425> _p1;
EcsPool<Component359> _p2;
EcsPool<Component15> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component425>().Inc<Component359>().End();
   _p1 = _world.GetPool<Component425>();
   _p2 = _world.GetPool<Component359>();
   _pl = _world.GetPool<Component15>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System513 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component15> _p1;
EcsPool<Component192> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component15>().End();
   _p1 = _world.GetPool<Component15>();
   _pl = _world.GetPool<Component192>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System514 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component191> _p1;
EcsPool<Component315> _p2;
EcsPool<Component0> _p3;
EcsPool<Component51> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component191>().Inc<Component315>().Inc<Component0>().End();
   _p1 = _world.GetPool<Component191>();
   _p2 = _world.GetPool<Component315>();
   _p3 = _world.GetPool<Component0>();
   _pl = _world.GetPool<Component51>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System515 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component230> _p1;
EcsPool<Component180> _p2;
EcsPool<Component128> _p3;
EcsPool<Component415> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component230>().Inc<Component180>().Inc<Component128>().End();
   _p1 = _world.GetPool<Component230>();
   _p2 = _world.GetPool<Component180>();
   _p3 = _world.GetPool<Component128>();
   _pl = _world.GetPool<Component415>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System516 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component465> _p1;
EcsPool<Component353> _p2;
EcsPool<Component481> _p3;
EcsPool<Component376> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component465>().Inc<Component353>().Inc<Component481>().End();
   _p1 = _world.GetPool<Component465>();
   _p2 = _world.GetPool<Component353>();
   _p3 = _world.GetPool<Component481>();
   _pl = _world.GetPool<Component376>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System517 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component456> _p1;
EcsPool<Component407> _p2;
EcsPool<Component356> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component456>().Inc<Component407>().End();
   _p1 = _world.GetPool<Component456>();
   _p2 = _world.GetPool<Component407>();
   _pl = _world.GetPool<Component356>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System518 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component51> _p1;
EcsPool<Component247> _p2;
EcsPool<Component335> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component51>().Inc<Component247>().End();
   _p1 = _world.GetPool<Component51>();
   _p2 = _world.GetPool<Component247>();
   _pl = _world.GetPool<Component335>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System519 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component24> _p1;
EcsPool<Component387> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component24>().End();
   _p1 = _world.GetPool<Component24>();
   _pl = _world.GetPool<Component387>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System520 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component175> _p1;
EcsPool<Component228> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component175>().End();
   _p1 = _world.GetPool<Component175>();
   _pl = _world.GetPool<Component228>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System521 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component355> _p1;
EcsPool<Component151> _p2;
EcsPool<Component109> _p3;
EcsPool<Component315> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component355>().Inc<Component151>().Inc<Component109>().End();
   _p1 = _world.GetPool<Component355>();
   _p2 = _world.GetPool<Component151>();
   _p3 = _world.GetPool<Component109>();
   _pl = _world.GetPool<Component315>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System522 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component366> _p1;
EcsPool<Component220> _p2;
EcsPool<Component212> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component366>().Inc<Component220>().End();
   _p1 = _world.GetPool<Component366>();
   _p2 = _world.GetPool<Component220>();
   _pl = _world.GetPool<Component212>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System523 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component455> _p1;
EcsPool<Component115> _p2;
EcsPool<Component176> _p3;
EcsPool<Component248> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component455>().Inc<Component115>().Inc<Component176>().End();
   _p1 = _world.GetPool<Component455>();
   _p2 = _world.GetPool<Component115>();
   _p3 = _world.GetPool<Component176>();
   _pl = _world.GetPool<Component248>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System524 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component398> _p1;
EcsPool<Component448> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component398>().End();
   _p1 = _world.GetPool<Component398>();
   _pl = _world.GetPool<Component448>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System525 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component404> _p1;
EcsPool<Component386> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component404>().End();
   _p1 = _world.GetPool<Component404>();
   _pl = _world.GetPool<Component386>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System526 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component403> _p1;
EcsPool<Component108> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component403>().End();
   _p1 = _world.GetPool<Component403>();
   _pl = _world.GetPool<Component108>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System527 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component283> _p1;
EcsPool<Component141> _p2;
EcsPool<Component107> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component283>().Inc<Component141>().End();
   _p1 = _world.GetPool<Component283>();
   _p2 = _world.GetPool<Component141>();
   _pl = _world.GetPool<Component107>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System528 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component162> _p1;
EcsPool<Component476> _p2;
EcsPool<Component164> _p3;
EcsPool<Component304> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component162>().Inc<Component476>().Inc<Component164>().End();
   _p1 = _world.GetPool<Component162>();
   _p2 = _world.GetPool<Component476>();
   _p3 = _world.GetPool<Component164>();
   _pl = _world.GetPool<Component304>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System529 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component452> _p1;
EcsPool<Component236> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component452>().End();
   _p1 = _world.GetPool<Component452>();
   _pl = _world.GetPool<Component236>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System530 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component188> _p1;
EcsPool<Component356> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component188>().End();
   _p1 = _world.GetPool<Component188>();
   _pl = _world.GetPool<Component356>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System531 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component174> _p1;
EcsPool<Component9> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component174>().End();
   _p1 = _world.GetPool<Component174>();
   _pl = _world.GetPool<Component9>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System532 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component244> _p1;
EcsPool<Component414> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component244>().End();
   _p1 = _world.GetPool<Component244>();
   _pl = _world.GetPool<Component414>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System533 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component116> _p1;
EcsPool<Component375> _p2;
EcsPool<Component498> _p3;
EcsPool<Component284> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component116>().Inc<Component375>().Inc<Component498>().End();
   _p1 = _world.GetPool<Component116>();
   _p2 = _world.GetPool<Component375>();
   _p3 = _world.GetPool<Component498>();
   _pl = _world.GetPool<Component284>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System534 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component76> _p1;
EcsPool<Component352> _p2;
EcsPool<Component161> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component76>().Inc<Component352>().End();
   _p1 = _world.GetPool<Component76>();
   _p2 = _world.GetPool<Component352>();
   _pl = _world.GetPool<Component161>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System535 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component132> _p1;
EcsPool<Component488> _p2;
EcsPool<Component246> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component132>().Inc<Component488>().End();
   _p1 = _world.GetPool<Component132>();
   _p2 = _world.GetPool<Component488>();
   _pl = _world.GetPool<Component246>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System536 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component326> _p1;
EcsPool<Component173> _p2;
EcsPool<Component199> _p3;
EcsPool<Component10> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component326>().Inc<Component173>().Inc<Component199>().End();
   _p1 = _world.GetPool<Component326>();
   _p2 = _world.GetPool<Component173>();
   _p3 = _world.GetPool<Component199>();
   _pl = _world.GetPool<Component10>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System537 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component235> _p1;
EcsPool<Component329> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component235>().End();
   _p1 = _world.GetPool<Component235>();
   _pl = _world.GetPool<Component329>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System538 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component59> _p1;
EcsPool<Component224> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component59>().End();
   _p1 = _world.GetPool<Component59>();
   _pl = _world.GetPool<Component224>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System539 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component490> _p1;
EcsPool<Component209> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component490>().End();
   _p1 = _world.GetPool<Component490>();
   _pl = _world.GetPool<Component209>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System540 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component496> _p1;
EcsPool<Component229> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component496>().End();
   _p1 = _world.GetPool<Component496>();
   _pl = _world.GetPool<Component229>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System541 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component486> _p1;
EcsPool<Component159> _p2;
EcsPool<Component194> _p3;
EcsPool<Component400> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component486>().Inc<Component159>().Inc<Component194>().End();
   _p1 = _world.GetPool<Component486>();
   _p2 = _world.GetPool<Component159>();
   _p3 = _world.GetPool<Component194>();
   _pl = _world.GetPool<Component400>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System542 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component266> _p1;
EcsPool<Component108> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component266>().End();
   _p1 = _world.GetPool<Component266>();
   _pl = _world.GetPool<Component108>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System543 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component407> _p1;
EcsPool<Component399> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component407>().End();
   _p1 = _world.GetPool<Component407>();
   _pl = _world.GetPool<Component399>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System544 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component142> _p1;
EcsPool<Component267> _p2;
EcsPool<Component319> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component142>().Inc<Component267>().End();
   _p1 = _world.GetPool<Component142>();
   _p2 = _world.GetPool<Component267>();
   _pl = _world.GetPool<Component319>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System545 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component313> _p1;
EcsPool<Component339> _p2;
EcsPool<Component30> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component313>().Inc<Component339>().End();
   _p1 = _world.GetPool<Component313>();
   _p2 = _world.GetPool<Component339>();
   _pl = _world.GetPool<Component30>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System546 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component475> _p1;
EcsPool<Component499> _p2;
EcsPool<Component51> _p3;
EcsPool<Component8> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component475>().Inc<Component499>().Inc<Component51>().End();
   _p1 = _world.GetPool<Component475>();
   _p2 = _world.GetPool<Component499>();
   _p3 = _world.GetPool<Component51>();
   _pl = _world.GetPool<Component8>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System547 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component249> _p1;
EcsPool<Component57> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component249>().End();
   _p1 = _world.GetPool<Component249>();
   _pl = _world.GetPool<Component57>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System548 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component486> _p1;
EcsPool<Component294> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component486>().End();
   _p1 = _world.GetPool<Component486>();
   _pl = _world.GetPool<Component294>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System549 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component484> _p1;
EcsPool<Component355> _pl;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component484>().End();
   _p1 = _world.GetPool<Component484>();
   _pl = _world.GetPool<Component355>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   if (_pl.Has(entity))
   {
    _pl.Del(entity);
   }
   else
   {
    _pl.Add(entity);
   }
  }
 }
}

class System550 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component411> _p1;
EcsPool<Component146> _p2;
EcsPool<Component329> _p3;
EcsPool<Component52> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component411>().Inc<Component146>().Inc<Component329>().End();
   _p1 = _world.GetPool<Component411>();
   _p2 = _world.GetPool<Component146>();
   _p3 = _world.GetPool<Component329>();
   _pl = _world.GetPool<Component52>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System551 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component159> _p1;
EcsPool<Component406> _p2;
EcsPool<Component90> _p3;
EcsPool<Component439> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component159>().Inc<Component406>().Inc<Component90>().End();
   _p1 = _world.GetPool<Component159>();
   _p2 = _world.GetPool<Component406>();
   _p3 = _world.GetPool<Component90>();
   _pl = _world.GetPool<Component439>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System552 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component336> _p1;
EcsPool<Component18> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component336>().End();
   _p1 = _world.GetPool<Component336>();
   _pl = _world.GetPool<Component18>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System553 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component292> _p1;
EcsPool<Component405> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component292>().End();
   _p1 = _world.GetPool<Component292>();
   _pl = _world.GetPool<Component405>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System554 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component177> _p1;
EcsPool<Component370> _p2;
EcsPool<Component62> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component177>().Inc<Component370>().End();
   _p1 = _world.GetPool<Component177>();
   _p2 = _world.GetPool<Component370>();
   _pl = _world.GetPool<Component62>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System555 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component253> _p1;
EcsPool<Component377> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component253>().End();
   _p1 = _world.GetPool<Component253>();
   _pl = _world.GetPool<Component377>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System556 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component150> _p1;
EcsPool<Component109> _p2;
EcsPool<Component151> _p3;
EcsPool<Component109> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component150>().Inc<Component109>().Inc<Component151>().End();
   _p1 = _world.GetPool<Component150>();
   _p2 = _world.GetPool<Component109>();
   _p3 = _world.GetPool<Component151>();
   _pl = _world.GetPool<Component109>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System557 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component121> _p1;
EcsPool<Component276> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component121>().End();
   _p1 = _world.GetPool<Component121>();
   _pl = _world.GetPool<Component276>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System558 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component415> _p1;
EcsPool<Component455> _p2;
EcsPool<Component211> _p3;
EcsPool<Component355> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component415>().Inc<Component455>().Inc<Component211>().End();
   _p1 = _world.GetPool<Component415>();
   _p2 = _world.GetPool<Component455>();
   _p3 = _world.GetPool<Component211>();
   _pl = _world.GetPool<Component355>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System559 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component417> _p1;
EcsPool<Component260> _p2;
EcsPool<Component390> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component417>().Inc<Component260>().End();
   _p1 = _world.GetPool<Component417>();
   _p2 = _world.GetPool<Component260>();
   _pl = _world.GetPool<Component390>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System560 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component457> _p1;
EcsPool<Component385> _p2;
EcsPool<Component60> _p3;
EcsPool<Component401> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component457>().Inc<Component385>().Inc<Component60>().End();
   _p1 = _world.GetPool<Component457>();
   _p2 = _world.GetPool<Component385>();
   _p3 = _world.GetPool<Component60>();
   _pl = _world.GetPool<Component401>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System561 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component66> _p1;
EcsPool<Component240> _p2;
EcsPool<Component264> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component66>().Inc<Component240>().End();
   _p1 = _world.GetPool<Component66>();
   _p2 = _world.GetPool<Component240>();
   _pl = _world.GetPool<Component264>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System562 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component221> _p1;
EcsPool<Component117> _p2;
EcsPool<Component174> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component221>().Inc<Component117>().End();
   _p1 = _world.GetPool<Component221>();
   _p2 = _world.GetPool<Component117>();
   _pl = _world.GetPool<Component174>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System563 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component223> _p1;
EcsPool<Component177> _p2;
EcsPool<Component34> _p3;
EcsPool<Component210> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component223>().Inc<Component177>().Inc<Component34>().End();
   _p1 = _world.GetPool<Component223>();
   _p2 = _world.GetPool<Component177>();
   _p3 = _world.GetPool<Component34>();
   _pl = _world.GetPool<Component210>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System564 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component443> _p1;
EcsPool<Component297> _p2;
EcsPool<Component50> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component443>().Inc<Component297>().End();
   _p1 = _world.GetPool<Component443>();
   _p2 = _world.GetPool<Component297>();
   _pl = _world.GetPool<Component50>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System565 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component468> _p1;
EcsPool<Component162> _p2;
EcsPool<Component287> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component468>().Inc<Component162>().End();
   _p1 = _world.GetPool<Component468>();
   _p2 = _world.GetPool<Component162>();
   _pl = _world.GetPool<Component287>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System566 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component62> _p1;
EcsPool<Component297> _p2;
EcsPool<Component436> _p3;
EcsPool<Component232> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component62>().Inc<Component297>().Inc<Component436>().End();
   _p1 = _world.GetPool<Component62>();
   _p2 = _world.GetPool<Component297>();
   _p3 = _world.GetPool<Component436>();
   _pl = _world.GetPool<Component232>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System567 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component416> _p1;
EcsPool<Component480> _p2;
EcsPool<Component191> _p3;
EcsPool<Component174> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component416>().Inc<Component480>().Inc<Component191>().End();
   _p1 = _world.GetPool<Component416>();
   _p2 = _world.GetPool<Component480>();
   _p3 = _world.GetPool<Component191>();
   _pl = _world.GetPool<Component174>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System568 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component317> _p1;
EcsPool<Component34> _p2;
EcsPool<Component478> _p3;
EcsPool<Component42> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component317>().Inc<Component34>().Inc<Component478>().End();
   _p1 = _world.GetPool<Component317>();
   _p2 = _world.GetPool<Component34>();
   _p3 = _world.GetPool<Component478>();
   _pl = _world.GetPool<Component42>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System569 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component344> _p1;
EcsPool<Component369> _p2;
EcsPool<Component399> _p3;
EcsPool<Component159> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component344>().Inc<Component369>().Inc<Component399>().End();
   _p1 = _world.GetPool<Component344>();
   _p2 = _world.GetPool<Component369>();
   _p3 = _world.GetPool<Component399>();
   _pl = _world.GetPool<Component159>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System570 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component493> _p1;
EcsPool<Component231> _p2;
EcsPool<Component33> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component493>().Inc<Component231>().End();
   _p1 = _world.GetPool<Component493>();
   _p2 = _world.GetPool<Component231>();
   _pl = _world.GetPool<Component33>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System571 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component461> _p1;
EcsPool<Component238> _p2;
EcsPool<Component317> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component461>().Inc<Component238>().End();
   _p1 = _world.GetPool<Component461>();
   _p2 = _world.GetPool<Component238>();
   _pl = _world.GetPool<Component317>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System572 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component319> _p1;
EcsPool<Component166> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component319>().End();
   _p1 = _world.GetPool<Component319>();
   _pl = _world.GetPool<Component166>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System573 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component397> _p1;
EcsPool<Component113> _p2;
EcsPool<Component251> _p3;
EcsPool<Component4> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component397>().Inc<Component113>().Inc<Component251>().End();
   _p1 = _world.GetPool<Component397>();
   _p2 = _world.GetPool<Component113>();
   _p3 = _world.GetPool<Component251>();
   _pl = _world.GetPool<Component4>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System574 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component327> _p1;
EcsPool<Component13> _p2;
EcsPool<Component374> _p3;
EcsPool<Component201> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component327>().Inc<Component13>().Inc<Component374>().End();
   _p1 = _world.GetPool<Component327>();
   _p2 = _world.GetPool<Component13>();
   _p3 = _world.GetPool<Component374>();
   _pl = _world.GetPool<Component201>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System575 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component230> _p1;
EcsPool<Component49> _p2;
EcsPool<Component309> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component230>().Inc<Component49>().End();
   _p1 = _world.GetPool<Component230>();
   _p2 = _world.GetPool<Component49>();
   _pl = _world.GetPool<Component309>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System576 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component176> _p1;
EcsPool<Component200> _p2;
EcsPool<Component400> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component176>().Inc<Component200>().End();
   _p1 = _world.GetPool<Component176>();
   _p2 = _world.GetPool<Component200>();
   _pl = _world.GetPool<Component400>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System577 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component206> _p1;
EcsPool<Component421> _p2;
EcsPool<Component69> _p3;
EcsPool<Component3> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component206>().Inc<Component421>().Inc<Component69>().End();
   _p1 = _world.GetPool<Component206>();
   _p2 = _world.GetPool<Component421>();
   _p3 = _world.GetPool<Component69>();
   _pl = _world.GetPool<Component3>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System578 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component427> _p1;
EcsPool<Component330> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component427>().End();
   _p1 = _world.GetPool<Component427>();
   _pl = _world.GetPool<Component330>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System579 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component116> _p1;
EcsPool<Component270> _p2;
EcsPool<Component109> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component116>().Inc<Component270>().End();
   _p1 = _world.GetPool<Component116>();
   _p2 = _world.GetPool<Component270>();
   _pl = _world.GetPool<Component109>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System580 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component386> _p1;
EcsPool<Component371> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component386>().End();
   _p1 = _world.GetPool<Component386>();
   _pl = _world.GetPool<Component371>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System581 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component452> _p1;
EcsPool<Component419> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component452>().End();
   _p1 = _world.GetPool<Component452>();
   _pl = _world.GetPool<Component419>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System582 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component227> _p1;
EcsPool<Component38> _p2;
EcsPool<Component469> _p3;
EcsPool<Component16> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component227>().Inc<Component38>().Inc<Component469>().End();
   _p1 = _world.GetPool<Component227>();
   _p2 = _world.GetPool<Component38>();
   _p3 = _world.GetPool<Component469>();
   _pl = _world.GetPool<Component16>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System583 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component25> _p1;
EcsPool<Component458> _p2;
EcsPool<Component494> _p3;
EcsPool<Component262> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component25>().Inc<Component458>().Inc<Component494>().End();
   _p1 = _world.GetPool<Component25>();
   _p2 = _world.GetPool<Component458>();
   _p3 = _world.GetPool<Component494>();
   _pl = _world.GetPool<Component262>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System584 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component223> _p1;
EcsPool<Component103> _p2;
EcsPool<Component285> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component223>().Inc<Component103>().End();
   _p1 = _world.GetPool<Component223>();
   _p2 = _world.GetPool<Component103>();
   _pl = _world.GetPool<Component285>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System585 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component416> _p1;
EcsPool<Component207> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component416>().End();
   _p1 = _world.GetPool<Component416>();
   _pl = _world.GetPool<Component207>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System586 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component347> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().End();
   _p1 = _world.GetPool<Component245>();
   _pl = _world.GetPool<Component347>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System587 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component15> _p1;
EcsPool<Component323> _p2;
EcsPool<Component173> _p3;
EcsPool<Component177> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component15>().Inc<Component323>().Inc<Component173>().End();
   _p1 = _world.GetPool<Component15>();
   _p2 = _world.GetPool<Component323>();
   _p3 = _world.GetPool<Component173>();
   _pl = _world.GetPool<Component177>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System588 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component243> _p1;
EcsPool<Component265> _p2;
EcsPool<Component102> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component243>().Inc<Component265>().End();
   _p1 = _world.GetPool<Component243>();
   _p2 = _world.GetPool<Component265>();
   _pl = _world.GetPool<Component102>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System589 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component358> _p1;
EcsPool<Component42> _p2;
EcsPool<Component357> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component358>().Inc<Component42>().End();
   _p1 = _world.GetPool<Component358>();
   _p2 = _world.GetPool<Component42>();
   _pl = _world.GetPool<Component357>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System590 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component255> _p1;
EcsPool<Component473> _p2;
EcsPool<Component362> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component255>().Inc<Component473>().End();
   _p1 = _world.GetPool<Component255>();
   _p2 = _world.GetPool<Component473>();
   _pl = _world.GetPool<Component362>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System591 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component190> _p1;
EcsPool<Component65> _p2;
EcsPool<Component44> _p3;
EcsPool<Component45> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component190>().Inc<Component65>().Inc<Component44>().End();
   _p1 = _world.GetPool<Component190>();
   _p2 = _world.GetPool<Component65>();
   _p3 = _world.GetPool<Component44>();
   _pl = _world.GetPool<Component45>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System592 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component165> _p1;
EcsPool<Component147> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component165>().End();
   _p1 = _world.GetPool<Component165>();
   _pl = _world.GetPool<Component147>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System593 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component12> _p1;
EcsPool<Component484> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component12>().End();
   _p1 = _world.GetPool<Component12>();
   _pl = _world.GetPool<Component484>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System594 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component182> _p1;
EcsPool<Component179> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component182>().End();
   _p1 = _world.GetPool<Component182>();
   _pl = _world.GetPool<Component179>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System595 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component261> _p1;
EcsPool<Component104> _p2;
EcsPool<Component25> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component261>().Inc<Component104>().End();
   _p1 = _world.GetPool<Component261>();
   _p2 = _world.GetPool<Component104>();
   _pl = _world.GetPool<Component25>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System596 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component404> _p1;
EcsPool<Component364> _p2;
EcsPool<Component291> _p3;
EcsPool<Component304> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component404>().Inc<Component364>().Inc<Component291>().End();
   _p1 = _world.GetPool<Component404>();
   _p2 = _world.GetPool<Component364>();
   _p3 = _world.GetPool<Component291>();
   _pl = _world.GetPool<Component304>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System597 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component259> _p1;
EcsPool<Component355> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component259>().End();
   _p1 = _world.GetPool<Component259>();
   _pl = _world.GetPool<Component355>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System598 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component404> _p1;
EcsPool<Component140> _p2;
EcsPool<Component366> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component404>().Inc<Component140>().End();
   _p1 = _world.GetPool<Component404>();
   _p2 = _world.GetPool<Component140>();
   _pl = _world.GetPool<Component366>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System599 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component29> _p1;
EcsPool<Component63> _p2;
EcsPool<Component54> _pl;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component29>().Inc<Component63>().End();
   _p1 = _world.GetPool<Component29>();
   _p2 = _world.GetPool<Component63>();
   _pl = _world.GetPool<Component54>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

}
