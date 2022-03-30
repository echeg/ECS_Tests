using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System0 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component97> _p1;
EcsPool<Component341> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component97>().End();
   _p1 = _world.GetPool<Component97>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System1 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component23> _p1;
EcsPool<Component82> _p2;
EcsPool<Component174> _p3;
EcsPool<Component94> _p4;
EcsPool<Component273> _p5;
EcsPool<Component233> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component23>().Inc<Component82>().Inc<Component174>().Inc<Component94>().Inc<Component273>().End();
   _p1 = _world.GetPool<Component23>();
   _p2 = _world.GetPool<Component82>();
   _p3 = _world.GetPool<Component174>();
   _p4 = _world.GetPool<Component94>();
   _p5 = _world.GetPool<Component273>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System2 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component194> _p1;
EcsPool<Component154> _p2;
EcsPool<Component5> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component194>().Inc<Component154>().End();
   _p1 = _world.GetPool<Component194>();
   _p2 = _world.GetPool<Component154>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System3 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component4> _p1;
EcsPool<Component78> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component4>().End();
   _p1 = _world.GetPool<Component4>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System4 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component73> _p1;
EcsPool<Component302> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component73>().End();
   _p1 = _world.GetPool<Component73>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System5 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component128> _p1;
EcsPool<Component102> _p2;
EcsPool<Component74> _p3;
EcsPool<Component193> _p4;
EcsPool<Component133> _p5;
EcsPool<Component19> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component128>().Inc<Component102>().Inc<Component74>().Inc<Component193>().Inc<Component133>().End();
   _p1 = _world.GetPool<Component128>();
   _p2 = _world.GetPool<Component102>();
   _p3 = _world.GetPool<Component74>();
   _p4 = _world.GetPool<Component193>();
   _p5 = _world.GetPool<Component133>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System6 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component73> _p1;
EcsPool<Component312> _p2;
EcsPool<Component2> _p3;
EcsPool<Component172> _p4;
EcsPool<Component399> _p5;
EcsPool<Component108> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component73>().Inc<Component312>().Inc<Component2>().Inc<Component172>().Inc<Component399>().End();
   _p1 = _world.GetPool<Component73>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component2>();
   _p4 = _world.GetPool<Component172>();
   _p5 = _world.GetPool<Component399>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System7 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component220> _p1;
EcsPool<Component143> _p2;
EcsPool<Component78> _p3;
EcsPool<Component146> _p4;
EcsPool<Component81> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component220>().Inc<Component143>().Inc<Component78>().Inc<Component146>().End();
   _p1 = _world.GetPool<Component220>();
   _p2 = _world.GetPool<Component143>();
   _p3 = _world.GetPool<Component78>();
   _p4 = _world.GetPool<Component146>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System8 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component370> _p1;
EcsPool<Component155> _p2;
EcsPool<Component86> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component370>().Inc<Component155>().End();
   _p1 = _world.GetPool<Component370>();
   _p2 = _world.GetPool<Component155>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System9 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component239> _p1;
EcsPool<Component224> _p2;
EcsPool<Component47> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component239>().Inc<Component224>().End();
   _p1 = _world.GetPool<Component239>();
   _p2 = _world.GetPool<Component224>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System10 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component299> _p1;
EcsPool<Component196> _p2;
EcsPool<Component359> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component299>().Inc<Component196>().End();
   _p1 = _world.GetPool<Component299>();
   _p2 = _world.GetPool<Component196>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System11 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component185> _p1;
EcsPool<Component322> _p2;
EcsPool<Component394> _p3;
EcsPool<Component266> _p4;
EcsPool<Component179> _p5;
EcsPool<Component289> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component185>().Inc<Component322>().Inc<Component394>().Inc<Component266>().Inc<Component179>().End();
   _p1 = _world.GetPool<Component185>();
   _p2 = _world.GetPool<Component322>();
   _p3 = _world.GetPool<Component394>();
   _p4 = _world.GetPool<Component266>();
   _p5 = _world.GetPool<Component179>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System12 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component227> _p1;
EcsPool<Component20> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component227>().End();
   _p1 = _world.GetPool<Component227>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System13 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component230> _p1;
EcsPool<Component350> _p2;
EcsPool<Component195> _p3;
EcsPool<Component46> _p4;
EcsPool<Component109> _p5;
EcsPool<Component182> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component230>().Inc<Component350>().Inc<Component195>().Inc<Component46>().Inc<Component109>().End();
   _p1 = _world.GetPool<Component230>();
   _p2 = _world.GetPool<Component350>();
   _p3 = _world.GetPool<Component195>();
   _p4 = _world.GetPool<Component46>();
   _p5 = _world.GetPool<Component109>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System14 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component399> _p1;
EcsPool<Component304> _p2;
EcsPool<Component391> _p3;
EcsPool<Component207> _p4;
EcsPool<Component19> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component399>().Inc<Component304>().Inc<Component391>().Inc<Component207>().End();
   _p1 = _world.GetPool<Component399>();
   _p2 = _world.GetPool<Component304>();
   _p3 = _world.GetPool<Component391>();
   _p4 = _world.GetPool<Component207>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System15 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component16> _p1;
EcsPool<Component289> _p2;
EcsPool<Component354> _p3;
EcsPool<Component293> _p4;
EcsPool<Component194> _p5;
EcsPool<Component298> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component16>().Inc<Component289>().Inc<Component354>().Inc<Component293>().Inc<Component194>().End();
   _p1 = _world.GetPool<Component16>();
   _p2 = _world.GetPool<Component289>();
   _p3 = _world.GetPool<Component354>();
   _p4 = _world.GetPool<Component293>();
   _p5 = _world.GetPool<Component194>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System16 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component206> _p2;
EcsPool<Component212> _p3;
EcsPool<Component399> _p4;
EcsPool<Component322> _p5;
EcsPool<Component373> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component206>().Inc<Component212>().Inc<Component399>().Inc<Component322>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component206>();
   _p3 = _world.GetPool<Component212>();
   _p4 = _world.GetPool<Component399>();
   _p5 = _world.GetPool<Component322>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System17 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component276> _p1;
EcsPool<Component299> _p2;
EcsPool<Component256> _p3;
EcsPool<Component18> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component276>().Inc<Component299>().Inc<Component256>().End();
   _p1 = _world.GetPool<Component276>();
   _p2 = _world.GetPool<Component299>();
   _p3 = _world.GetPool<Component256>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System18 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component349> _p1;
EcsPool<Component194> _p2;
EcsPool<Component255> _p3;
EcsPool<Component234> _p4;
EcsPool<Component43> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component349>().Inc<Component194>().Inc<Component255>().Inc<Component234>().End();
   _p1 = _world.GetPool<Component349>();
   _p2 = _world.GetPool<Component194>();
   _p3 = _world.GetPool<Component255>();
   _p4 = _world.GetPool<Component234>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System19 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component115> _p1;
EcsPool<Component265> _p2;
EcsPool<Component242> _p3;
EcsPool<Component299> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component115>().Inc<Component265>().Inc<Component242>().End();
   _p1 = _world.GetPool<Component115>();
   _p2 = _world.GetPool<Component265>();
   _p3 = _world.GetPool<Component242>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System20 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component367> _p1;
EcsPool<Component192> _p2;
EcsPool<Component165> _p3;
EcsPool<Component349> _p4;
EcsPool<Component377> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component367>().Inc<Component192>().Inc<Component165>().Inc<Component349>().End();
   _p1 = _world.GetPool<Component367>();
   _p2 = _world.GetPool<Component192>();
   _p3 = _world.GetPool<Component165>();
   _p4 = _world.GetPool<Component349>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System21 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component396> _p2;
EcsPool<Component268> _p3;
EcsPool<Component328> _p4;
EcsPool<Component51> _p5;
EcsPool<Component347> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().Inc<Component396>().Inc<Component268>().Inc<Component328>().Inc<Component51>().End();
   _p1 = _world.GetPool<Component224>();
   _p2 = _world.GetPool<Component396>();
   _p3 = _world.GetPool<Component268>();
   _p4 = _world.GetPool<Component328>();
   _p5 = _world.GetPool<Component51>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System22 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component137> _p1;
EcsPool<Component196> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component137>().End();
   _p1 = _world.GetPool<Component137>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System23 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component136> _p1;
EcsPool<Component356> _p2;
EcsPool<Component385> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component136>().Inc<Component356>().End();
   _p1 = _world.GetPool<Component136>();
   _p2 = _world.GetPool<Component356>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System24 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component47> _p1;
EcsPool<Component373> _p2;
EcsPool<Component339> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component47>().Inc<Component373>().End();
   _p1 = _world.GetPool<Component47>();
   _p2 = _world.GetPool<Component373>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System25 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component178> _p1;
EcsPool<Component161> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component178>().End();
   _p1 = _world.GetPool<Component178>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System26 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component310> _p1;
EcsPool<Component100> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component310>().End();
   _p1 = _world.GetPool<Component310>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System27 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component33> _p1;
EcsPool<Component127> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component33>().End();
   _p1 = _world.GetPool<Component33>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System28 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component315> _p1;
EcsPool<Component245> _p2;
EcsPool<Component206> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component315>().Inc<Component245>().End();
   _p1 = _world.GetPool<Component315>();
   _p2 = _world.GetPool<Component245>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System29 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component23> _p1;
EcsPool<Component247> _p2;
EcsPool<Component299> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component23>().Inc<Component247>().End();
   _p1 = _world.GetPool<Component23>();
   _p2 = _world.GetPool<Component247>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System30 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component260> _p1;
EcsPool<Component149> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component260>().End();
   _p1 = _world.GetPool<Component260>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System31 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component297> _p1;
EcsPool<Component247> _p2;
EcsPool<Component231> _p3;
EcsPool<Component97> _p4;
EcsPool<Component69> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component297>().Inc<Component247>().Inc<Component231>().Inc<Component97>().End();
   _p1 = _world.GetPool<Component297>();
   _p2 = _world.GetPool<Component247>();
   _p3 = _world.GetPool<Component231>();
   _p4 = _world.GetPool<Component97>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System32 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component308> _p1;
EcsPool<Component256> _p2;
EcsPool<Component199> _p3;
EcsPool<Component244> _p4;
EcsPool<Component394> _p5;
EcsPool<Component253> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component308>().Inc<Component256>().Inc<Component199>().Inc<Component244>().Inc<Component394>().End();
   _p1 = _world.GetPool<Component308>();
   _p2 = _world.GetPool<Component256>();
   _p3 = _world.GetPool<Component199>();
   _p4 = _world.GetPool<Component244>();
   _p5 = _world.GetPool<Component394>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System33 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component171> _p1;
EcsPool<Component216> _p2;
EcsPool<Component322> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component171>().Inc<Component216>().End();
   _p1 = _world.GetPool<Component171>();
   _p2 = _world.GetPool<Component216>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System34 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component295> _p1;
EcsPool<Component189> _p2;
EcsPool<Component324> _p3;
EcsPool<Component233> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component295>().Inc<Component189>().Inc<Component324>().End();
   _p1 = _world.GetPool<Component295>();
   _p2 = _world.GetPool<Component189>();
   _p3 = _world.GetPool<Component324>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System35 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component292> _p1;
EcsPool<Component390> _p2;
EcsPool<Component366> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component292>().Inc<Component390>().End();
   _p1 = _world.GetPool<Component292>();
   _p2 = _world.GetPool<Component390>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System36 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component109> _p1;
EcsPool<Component86> _p2;
EcsPool<Component25> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component109>().Inc<Component86>().End();
   _p1 = _world.GetPool<Component109>();
   _p2 = _world.GetPool<Component86>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System37 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component0> _p2;
EcsPool<Component172> _p3;
EcsPool<Component330> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().Inc<Component0>().Inc<Component172>().End();
   _p1 = _world.GetPool<Component224>();
   _p2 = _world.GetPool<Component0>();
   _p3 = _world.GetPool<Component172>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System38 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component356> _p1;
EcsPool<Component63> _p2;
EcsPool<Component31> _p3;
EcsPool<Component100> _p4;
EcsPool<Component125> _p5;
EcsPool<Component270> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component356>().Inc<Component63>().Inc<Component31>().Inc<Component100>().Inc<Component125>().End();
   _p1 = _world.GetPool<Component356>();
   _p2 = _world.GetPool<Component63>();
   _p3 = _world.GetPool<Component31>();
   _p4 = _world.GetPool<Component100>();
   _p5 = _world.GetPool<Component125>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System39 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component70> _p1;
EcsPool<Component250> _p2;
EcsPool<Component352> _p3;
EcsPool<Component61> _p4;
EcsPool<Component252> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component70>().Inc<Component250>().Inc<Component352>().Inc<Component61>().End();
   _p1 = _world.GetPool<Component70>();
   _p2 = _world.GetPool<Component250>();
   _p3 = _world.GetPool<Component352>();
   _p4 = _world.GetPool<Component61>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System40 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component376> _p1;
EcsPool<Component161> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component376>().End();
   _p1 = _world.GetPool<Component376>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System41 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component359> _p1;
EcsPool<Component43> _p2;
EcsPool<Component373> _p3;
EcsPool<Component14> _p4;
EcsPool<Component122> _p5;
EcsPool<Component205> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component359>().Inc<Component43>().Inc<Component373>().Inc<Component14>().Inc<Component122>().End();
   _p1 = _world.GetPool<Component359>();
   _p2 = _world.GetPool<Component43>();
   _p3 = _world.GetPool<Component373>();
   _p4 = _world.GetPool<Component14>();
   _p5 = _world.GetPool<Component122>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System42 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component102> _p1;
EcsPool<Component266> _p2;
EcsPool<Component199> _p3;
EcsPool<Component170> _p4;
EcsPool<Component173> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component102>().Inc<Component266>().Inc<Component199>().Inc<Component170>().End();
   _p1 = _world.GetPool<Component102>();
   _p2 = _world.GetPool<Component266>();
   _p3 = _world.GetPool<Component199>();
   _p4 = _world.GetPool<Component170>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System43 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component169> _p1;
EcsPool<Component253> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component169>().End();
   _p1 = _world.GetPool<Component169>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System44 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component241> _p1;
EcsPool<Component287> _p2;
EcsPool<Component365> _p3;
EcsPool<Component250> _p4;
EcsPool<Component264> _p5;
EcsPool<Component89> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component241>().Inc<Component287>().Inc<Component365>().Inc<Component250>().Inc<Component264>().End();
   _p1 = _world.GetPool<Component241>();
   _p2 = _world.GetPool<Component287>();
   _p3 = _world.GetPool<Component365>();
   _p4 = _world.GetPool<Component250>();
   _p5 = _world.GetPool<Component264>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System45 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component53> _p1;
EcsPool<Component318> _p2;
EcsPool<Component38> _p3;
EcsPool<Component41> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component53>().Inc<Component318>().Inc<Component38>().End();
   _p1 = _world.GetPool<Component53>();
   _p2 = _world.GetPool<Component318>();
   _p3 = _world.GetPool<Component38>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System46 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component304> _p1;
EcsPool<Component260> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component304>().End();
   _p1 = _world.GetPool<Component304>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System47 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component109> _p1;
EcsPool<Component264> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component109>().End();
   _p1 = _world.GetPool<Component109>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System48 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component265> _p1;
EcsPool<Component356> _p2;
EcsPool<Component198> _p3;
EcsPool<Component316> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component265>().Inc<Component356>().Inc<Component198>().End();
   _p1 = _world.GetPool<Component265>();
   _p2 = _world.GetPool<Component356>();
   _p3 = _world.GetPool<Component198>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System49 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component151> _p1;
EcsPool<Component205> _p2;
EcsPool<Component328> _p3;
EcsPool<Component234> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component151>().Inc<Component205>().Inc<Component328>().End();
   _p1 = _world.GetPool<Component151>();
   _p2 = _world.GetPool<Component205>();
   _p3 = _world.GetPool<Component328>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System50 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component99> _p1;
EcsPool<Component141> _p2;
EcsPool<Component13> _p3;
EcsPool<Component81> _p4;
EcsPool<Component138> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component99>().Inc<Component141>().Inc<Component13>().Inc<Component81>().End();
   _p1 = _world.GetPool<Component99>();
   _p2 = _world.GetPool<Component141>();
   _p3 = _world.GetPool<Component13>();
   _p4 = _world.GetPool<Component81>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System51 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component143> _p1;
EcsPool<Component11> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component143>().End();
   _p1 = _world.GetPool<Component143>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System52 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component100> _p1;
EcsPool<Component269> _p2;
EcsPool<Component273> _p3;
EcsPool<Component319> _p4;
EcsPool<Component95> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component100>().Inc<Component269>().Inc<Component273>().Inc<Component319>().End();
   _p1 = _world.GetPool<Component100>();
   _p2 = _world.GetPool<Component269>();
   _p3 = _world.GetPool<Component273>();
   _p4 = _world.GetPool<Component319>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System53 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component164> _p1;
EcsPool<Component220> _p2;
EcsPool<Component197> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component164>().Inc<Component220>().End();
   _p1 = _world.GetPool<Component164>();
   _p2 = _world.GetPool<Component220>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System54 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component120> _p1;
EcsPool<Component61> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component120>().End();
   _p1 = _world.GetPool<Component120>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System55 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component235> _p1;
EcsPool<Component304> _p2;
EcsPool<Component296> _p3;
EcsPool<Component124> _p4;
EcsPool<Component324> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component235>().Inc<Component304>().Inc<Component296>().Inc<Component124>().End();
   _p1 = _world.GetPool<Component235>();
   _p2 = _world.GetPool<Component304>();
   _p3 = _world.GetPool<Component296>();
   _p4 = _world.GetPool<Component124>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System56 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component214> _p1;
EcsPool<Component44> _p2;
EcsPool<Component335> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component214>().Inc<Component44>().End();
   _p1 = _world.GetPool<Component214>();
   _p2 = _world.GetPool<Component44>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System57 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component243> _p1;
EcsPool<Component354> _p2;
EcsPool<Component177> _p3;
EcsPool<Component25> _p4;
EcsPool<Component360> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component243>().Inc<Component354>().Inc<Component177>().Inc<Component25>().End();
   _p1 = _world.GetPool<Component243>();
   _p2 = _world.GetPool<Component354>();
   _p3 = _world.GetPool<Component177>();
   _p4 = _world.GetPool<Component25>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System58 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component165> _p1;
EcsPool<Component249> _p2;
EcsPool<Component335> _p3;
EcsPool<Component98> _p4;
EcsPool<Component353> _p5;
EcsPool<Component121> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component165>().Inc<Component249>().Inc<Component335>().Inc<Component98>().Inc<Component353>().End();
   _p1 = _world.GetPool<Component165>();
   _p2 = _world.GetPool<Component249>();
   _p3 = _world.GetPool<Component335>();
   _p4 = _world.GetPool<Component98>();
   _p5 = _world.GetPool<Component353>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System59 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component82> _p1;
EcsPool<Component278> _p2;
EcsPool<Component220> _p3;
EcsPool<Component122> _p4;
EcsPool<Component387> _p5;
EcsPool<Component385> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component82>().Inc<Component278>().Inc<Component220>().Inc<Component122>().Inc<Component387>().End();
   _p1 = _world.GetPool<Component82>();
   _p2 = _world.GetPool<Component278>();
   _p3 = _world.GetPool<Component220>();
   _p4 = _world.GetPool<Component122>();
   _p5 = _world.GetPool<Component387>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System60 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component228> _p1;
EcsPool<Component205> _p2;
EcsPool<Component38> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component228>().Inc<Component205>().End();
   _p1 = _world.GetPool<Component228>();
   _p2 = _world.GetPool<Component205>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System61 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component177> _p1;
EcsPool<Component202> _p2;
EcsPool<Component14> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component177>().Inc<Component202>().End();
   _p1 = _world.GetPool<Component177>();
   _p2 = _world.GetPool<Component202>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System62 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component62> _p1;
EcsPool<Component196> _p2;
EcsPool<Component266> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component62>().Inc<Component196>().End();
   _p1 = _world.GetPool<Component62>();
   _p2 = _world.GetPool<Component196>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System63 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component13> _p1;
EcsPool<Component29> _p2;
EcsPool<Component365> _p3;
EcsPool<Component318> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component13>().Inc<Component29>().Inc<Component365>().End();
   _p1 = _world.GetPool<Component13>();
   _p2 = _world.GetPool<Component29>();
   _p3 = _world.GetPool<Component365>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System64 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component204> _p1;
EcsPool<Component282> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component204>().End();
   _p1 = _world.GetPool<Component204>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System65 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component155> _p1;
EcsPool<Component185> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component155>().End();
   _p1 = _world.GetPool<Component155>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System66 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component355> _p1;
EcsPool<Component113> _p2;
EcsPool<Component308> _p3;
EcsPool<Component213> _p4;
EcsPool<Component245> _p5;
EcsPool<Component104> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component355>().Inc<Component113>().Inc<Component308>().Inc<Component213>().Inc<Component245>().End();
   _p1 = _world.GetPool<Component355>();
   _p2 = _world.GetPool<Component113>();
   _p3 = _world.GetPool<Component308>();
   _p4 = _world.GetPool<Component213>();
   _p5 = _world.GetPool<Component245>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System67 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component227> _p1;
EcsPool<Component58> _p2;
EcsPool<Component205> _p3;
EcsPool<Component27> _p4;
EcsPool<Component38> _p5;
EcsPool<Component315> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component227>().Inc<Component58>().Inc<Component205>().Inc<Component27>().Inc<Component38>().End();
   _p1 = _world.GetPool<Component227>();
   _p2 = _world.GetPool<Component58>();
   _p3 = _world.GetPool<Component205>();
   _p4 = _world.GetPool<Component27>();
   _p5 = _world.GetPool<Component38>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System68 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component247> _p1;
EcsPool<Component183> _p2;
EcsPool<Component134> _p3;
EcsPool<Component151> _p4;
EcsPool<Component163> _p5;
EcsPool<Component272> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component247>().Inc<Component183>().Inc<Component134>().Inc<Component151>().Inc<Component163>().End();
   _p1 = _world.GetPool<Component247>();
   _p2 = _world.GetPool<Component183>();
   _p3 = _world.GetPool<Component134>();
   _p4 = _world.GetPool<Component151>();
   _p5 = _world.GetPool<Component163>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System69 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component86> _p1;
EcsPool<Component357> _p2;
EcsPool<Component382> _p3;
EcsPool<Component52> _p4;
EcsPool<Component313> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component86>().Inc<Component357>().Inc<Component382>().Inc<Component52>().End();
   _p1 = _world.GetPool<Component86>();
   _p2 = _world.GetPool<Component357>();
   _p3 = _world.GetPool<Component382>();
   _p4 = _world.GetPool<Component52>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System70 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component63> _p1;
EcsPool<Component182> _p2;
EcsPool<Component102> _p3;
EcsPool<Component98> _p4;
EcsPool<Component72> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component63>().Inc<Component182>().Inc<Component102>().Inc<Component98>().End();
   _p1 = _world.GetPool<Component63>();
   _p2 = _world.GetPool<Component182>();
   _p3 = _world.GetPool<Component102>();
   _p4 = _world.GetPool<Component98>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System71 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component75> _p1;
EcsPool<Component277> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component75>().End();
   _p1 = _world.GetPool<Component75>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System72 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component268> _p1;
EcsPool<Component389> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component268>().End();
   _p1 = _world.GetPool<Component268>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System73 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component382> _p1;
EcsPool<Component105> _p2;
EcsPool<Component369> _p3;
EcsPool<Component207> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component382>().Inc<Component105>().Inc<Component369>().End();
   _p1 = _world.GetPool<Component382>();
   _p2 = _world.GetPool<Component105>();
   _p3 = _world.GetPool<Component369>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System74 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component386> _p1;
EcsPool<Component391> _p2;
EcsPool<Component49> _p3;
EcsPool<Component373> _p4;
EcsPool<Component211> _p5;
EcsPool<Component21> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component386>().Inc<Component391>().Inc<Component49>().Inc<Component373>().Inc<Component211>().End();
   _p1 = _world.GetPool<Component386>();
   _p2 = _world.GetPool<Component391>();
   _p3 = _world.GetPool<Component49>();
   _p4 = _world.GetPool<Component373>();
   _p5 = _world.GetPool<Component211>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System75 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component281> _p1;
EcsPool<Component392> _p2;
EcsPool<Component313> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component281>().Inc<Component392>().End();
   _p1 = _world.GetPool<Component281>();
   _p2 = _world.GetPool<Component392>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System76 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component268> _p1;
EcsPool<Component156> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component268>().End();
   _p1 = _world.GetPool<Component268>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System77 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component160> _p1;
EcsPool<Component332> _p2;
EcsPool<Component201> _p3;
EcsPool<Component293> _p4;
EcsPool<Component44> _p5;
EcsPool<Component356> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component160>().Inc<Component332>().Inc<Component201>().Inc<Component293>().Inc<Component44>().End();
   _p1 = _world.GetPool<Component160>();
   _p2 = _world.GetPool<Component332>();
   _p3 = _world.GetPool<Component201>();
   _p4 = _world.GetPool<Component293>();
   _p5 = _world.GetPool<Component44>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System78 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component354> _p1;
EcsPool<Component18> _p2;
EcsPool<Component240> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component354>().Inc<Component18>().End();
   _p1 = _world.GetPool<Component354>();
   _p2 = _world.GetPool<Component18>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System79 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component183> _p1;
EcsPool<Component314> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component183>().End();
   _p1 = _world.GetPool<Component183>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System80 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component381> _p1;
EcsPool<Component180> _p2;
EcsPool<Component166> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component381>().Inc<Component180>().End();
   _p1 = _world.GetPool<Component381>();
   _p2 = _world.GetPool<Component180>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System81 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component279> _p1;
EcsPool<Component397> _p2;
EcsPool<Component396> _p3;
EcsPool<Component61> _p4;
EcsPool<Component263> _p5;
EcsPool<Component328> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component279>().Inc<Component397>().Inc<Component396>().Inc<Component61>().Inc<Component263>().End();
   _p1 = _world.GetPool<Component279>();
   _p2 = _world.GetPool<Component397>();
   _p3 = _world.GetPool<Component396>();
   _p4 = _world.GetPool<Component61>();
   _p5 = _world.GetPool<Component263>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System82 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component161> _p1;
EcsPool<Component355> _p2;
EcsPool<Component217> _p3;
EcsPool<Component79> _p4;
EcsPool<Component105> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component161>().Inc<Component355>().Inc<Component217>().Inc<Component79>().End();
   _p1 = _world.GetPool<Component161>();
   _p2 = _world.GetPool<Component355>();
   _p3 = _world.GetPool<Component217>();
   _p4 = _world.GetPool<Component79>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System83 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component8> _p1;
EcsPool<Component306> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component8>().End();
   _p1 = _world.GetPool<Component8>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System84 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component228> _p1;
EcsPool<Component237> _p2;
EcsPool<Component180> _p3;
EcsPool<Component211> _p4;
EcsPool<Component325> _p5;
EcsPool<Component251> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component228>().Inc<Component237>().Inc<Component180>().Inc<Component211>().Inc<Component325>().End();
   _p1 = _world.GetPool<Component228>();
   _p2 = _world.GetPool<Component237>();
   _p3 = _world.GetPool<Component180>();
   _p4 = _world.GetPool<Component211>();
   _p5 = _world.GetPool<Component325>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System85 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component31> _p1;
EcsPool<Component372> _p2;
EcsPool<Component209> _p3;
EcsPool<Component306> _p4;
EcsPool<Component27> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component31>().Inc<Component372>().Inc<Component209>().Inc<Component306>().End();
   _p1 = _world.GetPool<Component31>();
   _p2 = _world.GetPool<Component372>();
   _p3 = _world.GetPool<Component209>();
   _p4 = _world.GetPool<Component306>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System86 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component2> _p1;
EcsPool<Component299> _p2;
EcsPool<Component212> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component2>().Inc<Component299>().End();
   _p1 = _world.GetPool<Component2>();
   _p2 = _world.GetPool<Component299>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System87 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component130> _p1;
EcsPool<Component389> _p2;
EcsPool<Component159> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component130>().Inc<Component389>().End();
   _p1 = _world.GetPool<Component130>();
   _p2 = _world.GetPool<Component389>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System88 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component99> _p1;
EcsPool<Component68> _p2;
EcsPool<Component273> _p3;
EcsPool<Component41> _p4;
EcsPool<Component282> _p5;
EcsPool<Component0> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component99>().Inc<Component68>().Inc<Component273>().Inc<Component41>().Inc<Component282>().End();
   _p1 = _world.GetPool<Component99>();
   _p2 = _world.GetPool<Component68>();
   _p3 = _world.GetPool<Component273>();
   _p4 = _world.GetPool<Component41>();
   _p5 = _world.GetPool<Component282>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System89 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component274> _p1;
EcsPool<Component313> _p2;
EcsPool<Component226> _p3;
EcsPool<Component59> _p4;
EcsPool<Component276> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component274>().Inc<Component313>().Inc<Component226>().Inc<Component59>().End();
   _p1 = _world.GetPool<Component274>();
   _p2 = _world.GetPool<Component313>();
   _p3 = _world.GetPool<Component226>();
   _p4 = _world.GetPool<Component59>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System90 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component316> _p1;
EcsPool<Component144> _p2;
EcsPool<Component0> _p3;
EcsPool<Component354> _p4;
EcsPool<Component6> _p5;
EcsPool<Component27> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component316>().Inc<Component144>().Inc<Component0>().Inc<Component354>().Inc<Component6>().End();
   _p1 = _world.GetPool<Component316>();
   _p2 = _world.GetPool<Component144>();
   _p3 = _world.GetPool<Component0>();
   _p4 = _world.GetPool<Component354>();
   _p5 = _world.GetPool<Component6>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System91 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component364> _p1;
EcsPool<Component88> _p2;
EcsPool<Component53> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component364>().Inc<Component88>().End();
   _p1 = _world.GetPool<Component364>();
   _p2 = _world.GetPool<Component88>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System92 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component54> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().End();
   _p1 = _world.GetPool<Component224>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System93 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component318> _p1;
EcsPool<Component267> _p2;
EcsPool<Component358> _p3;
EcsPool<Component283> _p4;
EcsPool<Component18> _p5;
EcsPool<Component147> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component318>().Inc<Component267>().Inc<Component358>().Inc<Component283>().Inc<Component18>().End();
   _p1 = _world.GetPool<Component318>();
   _p2 = _world.GetPool<Component267>();
   _p3 = _world.GetPool<Component358>();
   _p4 = _world.GetPool<Component283>();
   _p5 = _world.GetPool<Component18>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System94 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component129> _p1;
EcsPool<Component168> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component129>().End();
   _p1 = _world.GetPool<Component129>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System95 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component170> _p1;
EcsPool<Component42> _p2;
EcsPool<Component250> _p3;
EcsPool<Component363> _p4;
EcsPool<Component157> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component170>().Inc<Component42>().Inc<Component250>().Inc<Component363>().End();
   _p1 = _world.GetPool<Component170>();
   _p2 = _world.GetPool<Component42>();
   _p3 = _world.GetPool<Component250>();
   _p4 = _world.GetPool<Component363>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System96 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component383> _p1;
EcsPool<Component247> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component383>().End();
   _p1 = _world.GetPool<Component383>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System97 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component136> _p1;
EcsPool<Component85> _p2;
EcsPool<Component155> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component136>().Inc<Component85>().End();
   _p1 = _world.GetPool<Component136>();
   _p2 = _world.GetPool<Component85>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System98 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component192> _p1;
EcsPool<Component123> _p2;
EcsPool<Component362> _p3;
EcsPool<Component14> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component192>().Inc<Component123>().Inc<Component362>().End();
   _p1 = _world.GetPool<Component192>();
   _p2 = _world.GetPool<Component123>();
   _p3 = _world.GetPool<Component362>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System99 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component10> _p1;
EcsPool<Component15> _p2;
EcsPool<Component251> _p3;
EcsPool<Component216> _p4;
EcsPool<Component227> _p5;
EcsPool<Component48> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component10>().Inc<Component15>().Inc<Component251>().Inc<Component216>().Inc<Component227>().End();
   _p1 = _world.GetPool<Component10>();
   _p2 = _world.GetPool<Component15>();
   _p3 = _world.GetPool<Component251>();
   _p4 = _world.GetPool<Component216>();
   _p5 = _world.GetPool<Component227>();
   _pt = _world.GetPool<TicksCooldownComponent>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _p1.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

class System100 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component7> _p1;
EcsPool<Component354> _p2;
EcsPool<Component342> _p3;
EcsPool<Component40> _p4;
EcsPool<Component129> _p5;
EcsPool<Component356> _pl0;
EcsPool<Component187> _pl1;
EcsPool<Component375> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component7>().Inc<Component354>().Inc<Component342>().Inc<Component40>().Inc<Component129>().End();
   _p1 = _world.GetPool<Component7>();
   _p2 = _world.GetPool<Component354>();
   _p3 = _world.GetPool<Component342>();
   _p4 = _world.GetPool<Component40>();
   _p5 = _world.GetPool<Component129>();
   _pl0 = _world.GetPool<Component356>();
   _pl1 = _world.GetPool<Component187>();
   _pl2 = _world.GetPool<Component375>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System101 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component184> _p1;
EcsPool<Component363> _p2;
EcsPool<Component176> _pl0;
EcsPool<Component180> _pl1;
EcsPool<Component207> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component184>().Inc<Component363>().End();
   _p1 = _world.GetPool<Component184>();
   _p2 = _world.GetPool<Component363>();
   _pl0 = _world.GetPool<Component176>();
   _pl1 = _world.GetPool<Component180>();
   _pl2 = _world.GetPool<Component207>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System102 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component69> _p1;
EcsPool<Component174> _pl0;
EcsPool<Component73> _pl1;
EcsPool<Component318> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component69>().End();
   _p1 = _world.GetPool<Component69>();
   _pl0 = _world.GetPool<Component174>();
   _pl1 = _world.GetPool<Component73>();
   _pl2 = _world.GetPool<Component318>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System103 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component163> _p1;
EcsPool<Component55> _p2;
EcsPool<Component166> _p3;
EcsPool<Component159> _p4;
EcsPool<Component56> _pl0;
EcsPool<Component132> _pl1;
EcsPool<Component49> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component163>().Inc<Component55>().Inc<Component166>().Inc<Component159>().End();
   _p1 = _world.GetPool<Component163>();
   _p2 = _world.GetPool<Component55>();
   _p3 = _world.GetPool<Component166>();
   _p4 = _world.GetPool<Component159>();
   _pl0 = _world.GetPool<Component56>();
   _pl1 = _world.GetPool<Component132>();
   _pl2 = _world.GetPool<Component49>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System104 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component153> _p1;
EcsPool<Component55> _p2;
EcsPool<Component354> _pl0;
EcsPool<Component215> _pl1;
EcsPool<Component202> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component153>().Inc<Component55>().End();
   _p1 = _world.GetPool<Component153>();
   _p2 = _world.GetPool<Component55>();
   _pl0 = _world.GetPool<Component354>();
   _pl1 = _world.GetPool<Component215>();
   _pl2 = _world.GetPool<Component202>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System105 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component149> _p1;
EcsPool<Component105> _p2;
EcsPool<Component41> _p3;
EcsPool<Component206> _p4;
EcsPool<Component21> _p5;
EcsPool<Component179> _pl0;
EcsPool<Component297> _pl1;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component149>().Inc<Component105>().Inc<Component41>().Inc<Component206>().Inc<Component21>().End();
   _p1 = _world.GetPool<Component149>();
   _p2 = _world.GetPool<Component105>();
   _p3 = _world.GetPool<Component41>();
   _p4 = _world.GetPool<Component206>();
   _p5 = _world.GetPool<Component21>();
   _pl0 = _world.GetPool<Component179>();
   _pl1 = _world.GetPool<Component297>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System106 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component8> _p1;
EcsPool<Component160> _p2;
EcsPool<Component185> _pl0;
EcsPool<Component233> _pl1;
EcsPool<Component157> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component8>().Inc<Component160>().End();
   _p1 = _world.GetPool<Component8>();
   _p2 = _world.GetPool<Component160>();
   _pl0 = _world.GetPool<Component185>();
   _pl1 = _world.GetPool<Component233>();
   _pl2 = _world.GetPool<Component157>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System107 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component345> _p1;
EcsPool<Component76> _p2;
EcsPool<Component142> _p3;
EcsPool<Component309> _p4;
EcsPool<Component180> _p5;
EcsPool<Component207> _pl0;
EcsPool<Component351> _pl1;
EcsPool<Component187> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component345>().Inc<Component76>().Inc<Component142>().Inc<Component309>().Inc<Component180>().End();
   _p1 = _world.GetPool<Component345>();
   _p2 = _world.GetPool<Component76>();
   _p3 = _world.GetPool<Component142>();
   _p4 = _world.GetPool<Component309>();
   _p5 = _world.GetPool<Component180>();
   _pl0 = _world.GetPool<Component207>();
   _pl1 = _world.GetPool<Component351>();
   _pl2 = _world.GetPool<Component187>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System108 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component384> _p1;
EcsPool<Component396> _p2;
EcsPool<Component307> _p3;
EcsPool<Component68> _pl0;
EcsPool<Component221> _pl1;
EcsPool<Component38> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component384>().Inc<Component396>().Inc<Component307>().End();
   _p1 = _world.GetPool<Component384>();
   _p2 = _world.GetPool<Component396>();
   _p3 = _world.GetPool<Component307>();
   _pl0 = _world.GetPool<Component68>();
   _pl1 = _world.GetPool<Component221>();
   _pl2 = _world.GetPool<Component38>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System109 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component148> _p1;
EcsPool<Component374> _p2;
EcsPool<Component187> _p3;
EcsPool<Component57> _pl0;
EcsPool<Component324> _pl1;
EcsPool<Component28> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component148>().Inc<Component374>().Inc<Component187>().End();
   _p1 = _world.GetPool<Component148>();
   _p2 = _world.GetPool<Component374>();
   _p3 = _world.GetPool<Component187>();
   _pl0 = _world.GetPool<Component57>();
   _pl1 = _world.GetPool<Component324>();
   _pl2 = _world.GetPool<Component28>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System110 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component52> _p1;
EcsPool<Component138> _p2;
EcsPool<Component370> _p3;
EcsPool<Component383> _p4;
EcsPool<Component336> _p5;
EcsPool<Component158> _pl0;
EcsPool<Component399> _pl1;
EcsPool<Component270> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component52>().Inc<Component138>().Inc<Component370>().Inc<Component383>().Inc<Component336>().End();
   _p1 = _world.GetPool<Component52>();
   _p2 = _world.GetPool<Component138>();
   _p3 = _world.GetPool<Component370>();
   _p4 = _world.GetPool<Component383>();
   _p5 = _world.GetPool<Component336>();
   _pl0 = _world.GetPool<Component158>();
   _pl1 = _world.GetPool<Component399>();
   _pl2 = _world.GetPool<Component270>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System111 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component291> _p1;
EcsPool<Component138> _p2;
EcsPool<Component208> _p3;
EcsPool<Component378> _p4;
EcsPool<Component211> _pl0;
EcsPool<Component305> _pl1;
EcsPool<Component22> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component291>().Inc<Component138>().Inc<Component208>().Inc<Component378>().End();
   _p1 = _world.GetPool<Component291>();
   _p2 = _world.GetPool<Component138>();
   _p3 = _world.GetPool<Component208>();
   _p4 = _world.GetPool<Component378>();
   _pl0 = _world.GetPool<Component211>();
   _pl1 = _world.GetPool<Component305>();
   _pl2 = _world.GetPool<Component22>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System112 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component197> _p1;
EcsPool<Component317> _p2;
EcsPool<Component258> _p3;
EcsPool<Component221> _pl0;
EcsPool<Component25> _pl1;
EcsPool<Component272> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component197>().Inc<Component317>().Inc<Component258>().End();
   _p1 = _world.GetPool<Component197>();
   _p2 = _world.GetPool<Component317>();
   _p3 = _world.GetPool<Component258>();
   _pl0 = _world.GetPool<Component221>();
   _pl1 = _world.GetPool<Component25>();
   _pl2 = _world.GetPool<Component272>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System113 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component357> _p1;
EcsPool<Component80> _p2;
EcsPool<Component178> _p3;
EcsPool<Component12> _pl0;
EcsPool<Component211> _pl1;
EcsPool<Component46> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component357>().Inc<Component80>().Inc<Component178>().End();
   _p1 = _world.GetPool<Component357>();
   _p2 = _world.GetPool<Component80>();
   _p3 = _world.GetPool<Component178>();
   _pl0 = _world.GetPool<Component12>();
   _pl1 = _world.GetPool<Component211>();
   _pl2 = _world.GetPool<Component46>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System114 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component56> _p1;
EcsPool<Component316> _p2;
EcsPool<Component108> _pl0;
EcsPool<Component90> _pl1;
EcsPool<Component170> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component56>().Inc<Component316>().End();
   _p1 = _world.GetPool<Component56>();
   _p2 = _world.GetPool<Component316>();
   _pl0 = _world.GetPool<Component108>();
   _pl1 = _world.GetPool<Component90>();
   _pl2 = _world.GetPool<Component170>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System115 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component15> _p2;
EcsPool<Component29> _p3;
EcsPool<Component182> _pl0;
EcsPool<Component113> _pl1;
EcsPool<Component97> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().Inc<Component15>().Inc<Component29>().End();
   _p1 = _world.GetPool<Component224>();
   _p2 = _world.GetPool<Component15>();
   _p3 = _world.GetPool<Component29>();
   _pl0 = _world.GetPool<Component182>();
   _pl1 = _world.GetPool<Component113>();
   _pl2 = _world.GetPool<Component97>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System116 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component330> _p1;
EcsPool<Component13> _pl0;
EcsPool<Component59> _pl1;
EcsPool<Component17> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component330>().End();
   _p1 = _world.GetPool<Component330>();
   _pl0 = _world.GetPool<Component13>();
   _pl1 = _world.GetPool<Component59>();
   _pl2 = _world.GetPool<Component17>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System117 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component352> _p1;
EcsPool<Component1> _p2;
EcsPool<Component259> _p3;
EcsPool<Component6> _p4;
EcsPool<Component169> _pl0;
EcsPool<Component146> _pl1;
EcsPool<Component27> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component352>().Inc<Component1>().Inc<Component259>().Inc<Component6>().End();
   _p1 = _world.GetPool<Component352>();
   _p2 = _world.GetPool<Component1>();
   _p3 = _world.GetPool<Component259>();
   _p4 = _world.GetPool<Component6>();
   _pl0 = _world.GetPool<Component169>();
   _pl1 = _world.GetPool<Component146>();
   _pl2 = _world.GetPool<Component27>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System118 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component141> _p1;
EcsPool<Component25> _p2;
EcsPool<Component256> _p3;
EcsPool<Component380> _p4;
EcsPool<Component387> _pl0;
EcsPool<Component59> _pl1;
EcsPool<Component252> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component141>().Inc<Component25>().Inc<Component256>().Inc<Component380>().End();
   _p1 = _world.GetPool<Component141>();
   _p2 = _world.GetPool<Component25>();
   _p3 = _world.GetPool<Component256>();
   _p4 = _world.GetPool<Component380>();
   _pl0 = _world.GetPool<Component387>();
   _pl1 = _world.GetPool<Component59>();
   _pl2 = _world.GetPool<Component252>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System119 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component81> _p1;
EcsPool<Component292> _p2;
EcsPool<Component270> _p3;
EcsPool<Component121> _pl0;
EcsPool<Component135> _pl1;
EcsPool<Component211> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component81>().Inc<Component292>().Inc<Component270>().End();
   _p1 = _world.GetPool<Component81>();
   _p2 = _world.GetPool<Component292>();
   _p3 = _world.GetPool<Component270>();
   _pl0 = _world.GetPool<Component121>();
   _pl1 = _world.GetPool<Component135>();
   _pl2 = _world.GetPool<Component211>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System120 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component182> _p1;
EcsPool<Component288> _p2;
EcsPool<Component75> _p3;
EcsPool<Component108> _p4;
EcsPool<Component327> _p5;
EcsPool<Component256> _pl0;
EcsPool<Component298> _pl1;
EcsPool<Component344> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component182>().Inc<Component288>().Inc<Component75>().Inc<Component108>().Inc<Component327>().End();
   _p1 = _world.GetPool<Component182>();
   _p2 = _world.GetPool<Component288>();
   _p3 = _world.GetPool<Component75>();
   _p4 = _world.GetPool<Component108>();
   _p5 = _world.GetPool<Component327>();
   _pl0 = _world.GetPool<Component256>();
   _pl1 = _world.GetPool<Component298>();
   _pl2 = _world.GetPool<Component344>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System121 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component160> _p1;
EcsPool<Component170> _pl0;
EcsPool<Component258> _pl1;
EcsPool<Component44> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component160>().End();
   _p1 = _world.GetPool<Component160>();
   _pl0 = _world.GetPool<Component170>();
   _pl1 = _world.GetPool<Component258>();
   _pl2 = _world.GetPool<Component44>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System122 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component49> _p1;
EcsPool<Component146> _p2;
EcsPool<Component361> _p3;
EcsPool<Component63> _p4;
EcsPool<Component304> _pl0;
EcsPool<Component69> _pl1;
EcsPool<Component198> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component49>().Inc<Component146>().Inc<Component361>().Inc<Component63>().End();
   _p1 = _world.GetPool<Component49>();
   _p2 = _world.GetPool<Component146>();
   _p3 = _world.GetPool<Component361>();
   _p4 = _world.GetPool<Component63>();
   _pl0 = _world.GetPool<Component304>();
   _pl1 = _world.GetPool<Component69>();
   _pl2 = _world.GetPool<Component198>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System123 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component49> _p1;
EcsPool<Component195> _p2;
EcsPool<Component53> _pl0;
EcsPool<Component244> _pl1;
EcsPool<Component225> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component49>().Inc<Component195>().End();
   _p1 = _world.GetPool<Component49>();
   _p2 = _world.GetPool<Component195>();
   _pl0 = _world.GetPool<Component53>();
   _pl1 = _world.GetPool<Component244>();
   _pl2 = _world.GetPool<Component225>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System124 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component121> _p1;
EcsPool<Component189> _p2;
EcsPool<Component296> _p3;
EcsPool<Component107> _p4;
EcsPool<Component140> _pl0;
EcsPool<Component40> _pl1;
EcsPool<Component77> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component121>().Inc<Component189>().Inc<Component296>().Inc<Component107>().End();
   _p1 = _world.GetPool<Component121>();
   _p2 = _world.GetPool<Component189>();
   _p3 = _world.GetPool<Component296>();
   _p4 = _world.GetPool<Component107>();
   _pl0 = _world.GetPool<Component140>();
   _pl1 = _world.GetPool<Component40>();
   _pl2 = _world.GetPool<Component77>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System125 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component94> _p1;
EcsPool<Component38> _p2;
EcsPool<Component99> _pl0;
EcsPool<Component9> _pl1;
EcsPool<Component242> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component94>().Inc<Component38>().End();
   _p1 = _world.GetPool<Component94>();
   _p2 = _world.GetPool<Component38>();
   _pl0 = _world.GetPool<Component99>();
   _pl1 = _world.GetPool<Component9>();
   _pl2 = _world.GetPool<Component242>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System126 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component234> _p1;
EcsPool<Component219> _p2;
EcsPool<Component217> _pl0;
EcsPool<Component200> _pl1;
EcsPool<Component207> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component234>().Inc<Component219>().End();
   _p1 = _world.GetPool<Component234>();
   _p2 = _world.GetPool<Component219>();
   _pl0 = _world.GetPool<Component217>();
   _pl1 = _world.GetPool<Component200>();
   _pl2 = _world.GetPool<Component207>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System127 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component31> _p1;
EcsPool<Component145> _p2;
EcsPool<Component308> _p3;
EcsPool<Component58> _p4;
EcsPool<Component230> _p5;
EcsPool<Component142> _pl0;
EcsPool<Component162> _pl1;
EcsPool<Component23> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component31>().Inc<Component145>().Inc<Component308>().Inc<Component58>().Inc<Component230>().End();
   _p1 = _world.GetPool<Component31>();
   _p2 = _world.GetPool<Component145>();
   _p3 = _world.GetPool<Component308>();
   _p4 = _world.GetPool<Component58>();
   _p5 = _world.GetPool<Component230>();
   _pl0 = _world.GetPool<Component142>();
   _pl1 = _world.GetPool<Component162>();
   _pl2 = _world.GetPool<Component23>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System128 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component280> _p1;
EcsPool<Component54> _p2;
EcsPool<Component82> _p3;
EcsPool<Component30> _pl0;
EcsPool<Component49> _pl1;
EcsPool<Component223> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component280>().Inc<Component54>().Inc<Component82>().End();
   _p1 = _world.GetPool<Component280>();
   _p2 = _world.GetPool<Component54>();
   _p3 = _world.GetPool<Component82>();
   _pl0 = _world.GetPool<Component30>();
   _pl1 = _world.GetPool<Component49>();
   _pl2 = _world.GetPool<Component223>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System129 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component264> _p1;
EcsPool<Component62> _p2;
EcsPool<Component118> _p3;
EcsPool<Component4> _pl0;
EcsPool<Component163> _pl1;
EcsPool<Component331> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component264>().Inc<Component62>().Inc<Component118>().End();
   _p1 = _world.GetPool<Component264>();
   _p2 = _world.GetPool<Component62>();
   _p3 = _world.GetPool<Component118>();
   _pl0 = _world.GetPool<Component4>();
   _pl1 = _world.GetPool<Component163>();
   _pl2 = _world.GetPool<Component331>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System130 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component323> _p1;
EcsPool<Component363> _pl0;
EcsPool<Component295> _pl1;
EcsPool<Component226> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component323>().End();
   _p1 = _world.GetPool<Component323>();
   _pl0 = _world.GetPool<Component363>();
   _pl1 = _world.GetPool<Component295>();
   _pl2 = _world.GetPool<Component226>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System131 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component324> _p1;
EcsPool<Component229> _p2;
EcsPool<Component378> _pl0;
EcsPool<Component252> _pl1;
EcsPool<Component37> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component324>().Inc<Component229>().End();
   _p1 = _world.GetPool<Component324>();
   _p2 = _world.GetPool<Component229>();
   _pl0 = _world.GetPool<Component378>();
   _pl1 = _world.GetPool<Component252>();
   _pl2 = _world.GetPool<Component37>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System132 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component217> _p1;
EcsPool<Component375> _p2;
EcsPool<Component280> _p3;
EcsPool<Component237> _p4;
EcsPool<Component276> _pl0;
EcsPool<Component397> _pl1;
EcsPool<Component278> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component217>().Inc<Component375>().Inc<Component280>().Inc<Component237>().End();
   _p1 = _world.GetPool<Component217>();
   _p2 = _world.GetPool<Component375>();
   _p3 = _world.GetPool<Component280>();
   _p4 = _world.GetPool<Component237>();
   _pl0 = _world.GetPool<Component276>();
   _pl1 = _world.GetPool<Component397>();
   _pl2 = _world.GetPool<Component278>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System133 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component279> _p1;
EcsPool<Component213> _pl0;
EcsPool<Component383> _pl1;
EcsPool<Component16> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component279>().End();
   _p1 = _world.GetPool<Component279>();
   _pl0 = _world.GetPool<Component213>();
   _pl1 = _world.GetPool<Component383>();
   _pl2 = _world.GetPool<Component16>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System134 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component192> _p1;
EcsPool<Component257> _p2;
EcsPool<Component2> _p3;
EcsPool<Component354> _p4;
EcsPool<Component154> _p5;
EcsPool<Component82> _pl0;
EcsPool<Component203> _pl1;
EcsPool<Component186> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component192>().Inc<Component257>().Inc<Component2>().Inc<Component354>().Inc<Component154>().End();
   _p1 = _world.GetPool<Component192>();
   _p2 = _world.GetPool<Component257>();
   _p3 = _world.GetPool<Component2>();
   _p4 = _world.GetPool<Component354>();
   _p5 = _world.GetPool<Component154>();
   _pl0 = _world.GetPool<Component82>();
   _pl1 = _world.GetPool<Component203>();
   _pl2 = _world.GetPool<Component186>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System135 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component93> _p1;
EcsPool<Component385> _p2;
EcsPool<Component94> _pl0;
EcsPool<Component335> _pl1;
EcsPool<Component316> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component93>().Inc<Component385>().End();
   _p1 = _world.GetPool<Component93>();
   _p2 = _world.GetPool<Component385>();
   _pl0 = _world.GetPool<Component94>();
   _pl1 = _world.GetPool<Component335>();
   _pl2 = _world.GetPool<Component316>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System136 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component99> _p1;
EcsPool<Component9> _pl0;
EcsPool<Component301> _pl1;
EcsPool<Component201> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component99>().End();
   _p1 = _world.GetPool<Component99>();
   _pl0 = _world.GetPool<Component9>();
   _pl1 = _world.GetPool<Component301>();
   _pl2 = _world.GetPool<Component201>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System137 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component155> _p1;
EcsPool<Component232> _pl0;
EcsPool<Component247> _pl1;
EcsPool<Component351> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component155>().End();
   _p1 = _world.GetPool<Component155>();
   _pl0 = _world.GetPool<Component232>();
   _pl1 = _world.GetPool<Component247>();
   _pl2 = _world.GetPool<Component351>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System138 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component185> _p1;
EcsPool<Component120> _pl0;
EcsPool<Component126> _pl1;
EcsPool<Component110> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component185>().End();
   _p1 = _world.GetPool<Component185>();
   _pl0 = _world.GetPool<Component120>();
   _pl1 = _world.GetPool<Component126>();
   _pl2 = _world.GetPool<Component110>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System139 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component238> _p1;
EcsPool<Component340> _pl0;
EcsPool<Component347> _pl1;
EcsPool<Component316> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component238>().End();
   _p1 = _world.GetPool<Component238>();
   _pl0 = _world.GetPool<Component340>();
   _pl1 = _world.GetPool<Component347>();
   _pl2 = _world.GetPool<Component316>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System140 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component260> _p1;
EcsPool<Component321> _pl0;
EcsPool<Component274> _pl1;
EcsPool<Component224> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component260>().End();
   _p1 = _world.GetPool<Component260>();
   _pl0 = _world.GetPool<Component321>();
   _pl1 = _world.GetPool<Component274>();
   _pl2 = _world.GetPool<Component224>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System141 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component233> _p1;
EcsPool<Component89> _p2;
EcsPool<Component116> _p3;
EcsPool<Component282> _pl0;
EcsPool<Component295> _pl1;
EcsPool<Component143> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component233>().Inc<Component89>().Inc<Component116>().End();
   _p1 = _world.GetPool<Component233>();
   _p2 = _world.GetPool<Component89>();
   _p3 = _world.GetPool<Component116>();
   _pl0 = _world.GetPool<Component282>();
   _pl1 = _world.GetPool<Component295>();
   _pl2 = _world.GetPool<Component143>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System142 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component81> _p1;
EcsPool<Component233> _p2;
EcsPool<Component354> _p3;
EcsPool<Component269> _p4;
EcsPool<Component312> _p5;
EcsPool<Component181> _pl0;
EcsPool<Component371> _pl1;
EcsPool<Component223> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component81>().Inc<Component233>().Inc<Component354>().Inc<Component269>().Inc<Component312>().End();
   _p1 = _world.GetPool<Component81>();
   _p2 = _world.GetPool<Component233>();
   _p3 = _world.GetPool<Component354>();
   _p4 = _world.GetPool<Component269>();
   _p5 = _world.GetPool<Component312>();
   _pl0 = _world.GetPool<Component181>();
   _pl1 = _world.GetPool<Component371>();
   _pl2 = _world.GetPool<Component223>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System143 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component9> _p1;
EcsPool<Component50> _p2;
EcsPool<Component328> _p3;
EcsPool<Component368> _p4;
EcsPool<Component361> _p5;
EcsPool<Component77> _pl0;
EcsPool<Component76> _pl1;
EcsPool<Component48> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component9>().Inc<Component50>().Inc<Component328>().Inc<Component368>().Inc<Component361>().End();
   _p1 = _world.GetPool<Component9>();
   _p2 = _world.GetPool<Component50>();
   _p3 = _world.GetPool<Component328>();
   _p4 = _world.GetPool<Component368>();
   _p5 = _world.GetPool<Component361>();
   _pl0 = _world.GetPool<Component77>();
   _pl1 = _world.GetPool<Component76>();
   _pl2 = _world.GetPool<Component48>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System144 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component44> _p1;
EcsPool<Component147> _p2;
EcsPool<Component18> _p3;
EcsPool<Component282> _p4;
EcsPool<Component183> _pl0;
EcsPool<Component177> _pl1;
EcsPool<Component134> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component44>().Inc<Component147>().Inc<Component18>().Inc<Component282>().End();
   _p1 = _world.GetPool<Component44>();
   _p2 = _world.GetPool<Component147>();
   _p3 = _world.GetPool<Component18>();
   _p4 = _world.GetPool<Component282>();
   _pl0 = _world.GetPool<Component183>();
   _pl1 = _world.GetPool<Component177>();
   _pl2 = _world.GetPool<Component134>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System145 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component31> _p1;
EcsPool<Component211> _pl0;
EcsPool<Component65> _pl1;
EcsPool<Component115> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component31>().End();
   _p1 = _world.GetPool<Component31>();
   _pl0 = _world.GetPool<Component211>();
   _pl1 = _world.GetPool<Component65>();
   _pl2 = _world.GetPool<Component115>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System146 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component56> _p1;
EcsPool<Component283> _p2;
EcsPool<Component244> _p3;
EcsPool<Component39> _p4;
EcsPool<Component292> _p5;
EcsPool<Component155> _pl0;
EcsPool<Component182> _pl1;
EcsPool<Component325> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component56>().Inc<Component283>().Inc<Component244>().Inc<Component39>().Inc<Component292>().End();
   _p1 = _world.GetPool<Component56>();
   _p2 = _world.GetPool<Component283>();
   _p3 = _world.GetPool<Component244>();
   _p4 = _world.GetPool<Component39>();
   _p5 = _world.GetPool<Component292>();
   _pl0 = _world.GetPool<Component155>();
   _pl1 = _world.GetPool<Component182>();
   _pl2 = _world.GetPool<Component325>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System147 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component375> _p1;
EcsPool<Component93> _p2;
EcsPool<Component73> _pl0;
EcsPool<Component251> _pl1;
EcsPool<Component270> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component375>().Inc<Component93>().End();
   _p1 = _world.GetPool<Component375>();
   _p2 = _world.GetPool<Component93>();
   _pl0 = _world.GetPool<Component73>();
   _pl1 = _world.GetPool<Component251>();
   _pl2 = _world.GetPool<Component270>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System148 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component256> _p1;
EcsPool<Component208> _p2;
EcsPool<Component156> _p3;
EcsPool<Component13> _p4;
EcsPool<Component68> _p5;
EcsPool<Component28> _pl0;
EcsPool<Component250> _pl1;
EcsPool<Component396> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component256>().Inc<Component208>().Inc<Component156>().Inc<Component13>().Inc<Component68>().End();
   _p1 = _world.GetPool<Component256>();
   _p2 = _world.GetPool<Component208>();
   _p3 = _world.GetPool<Component156>();
   _p4 = _world.GetPool<Component13>();
   _p5 = _world.GetPool<Component68>();
   _pl0 = _world.GetPool<Component28>();
   _pl1 = _world.GetPool<Component250>();
   _pl2 = _world.GetPool<Component396>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System149 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component199> _p1;
EcsPool<Component50> _p2;
EcsPool<Component176> _p3;
EcsPool<Component135> _p4;
EcsPool<Component235> _p5;
EcsPool<Component149> _pl0;
EcsPool<Component159> _pl1;
EcsPool<Component157> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component199>().Inc<Component50>().Inc<Component176>().Inc<Component135>().Inc<Component235>().End();
   _p1 = _world.GetPool<Component199>();
   _p2 = _world.GetPool<Component50>();
   _p3 = _world.GetPool<Component176>();
   _p4 = _world.GetPool<Component135>();
   _p5 = _world.GetPool<Component235>();
   _pl0 = _world.GetPool<Component149>();
   _pl1 = _world.GetPool<Component159>();
   _pl2 = _world.GetPool<Component157>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System150 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component44> _p1;
EcsPool<Component393> _p2;
EcsPool<Component124> _p3;
EcsPool<Component322> _pl0;
EcsPool<Component185> _pl1;
EcsPool<Component320> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component44>().Inc<Component393>().Inc<Component124>().End();
   _p1 = _world.GetPool<Component44>();
   _p2 = _world.GetPool<Component393>();
   _p3 = _world.GetPool<Component124>();
   _pl0 = _world.GetPool<Component322>();
   _pl1 = _world.GetPool<Component185>();
   _pl2 = _world.GetPool<Component320>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System151 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component328> _p1;
EcsPool<Component286> _p2;
EcsPool<Component171> _p3;
EcsPool<Component325> _p4;
EcsPool<Component209> _pl0;
EcsPool<Component331> _pl1;
EcsPool<Component306> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component328>().Inc<Component286>().Inc<Component171>().Inc<Component325>().End();
   _p1 = _world.GetPool<Component328>();
   _p2 = _world.GetPool<Component286>();
   _p3 = _world.GetPool<Component171>();
   _p4 = _world.GetPool<Component325>();
   _pl0 = _world.GetPool<Component209>();
   _pl1 = _world.GetPool<Component331>();
   _pl2 = _world.GetPool<Component306>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System152 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component220> _p1;
EcsPool<Component222> _p2;
EcsPool<Component55> _p3;
EcsPool<Component52> _pl0;
EcsPool<Component47> _pl1;
EcsPool<Component337> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component220>().Inc<Component222>().Inc<Component55>().End();
   _p1 = _world.GetPool<Component220>();
   _p2 = _world.GetPool<Component222>();
   _p3 = _world.GetPool<Component55>();
   _pl0 = _world.GetPool<Component52>();
   _pl1 = _world.GetPool<Component47>();
   _pl2 = _world.GetPool<Component337>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System153 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component287> _p1;
EcsPool<Component320> _p2;
EcsPool<Component240> _p3;
EcsPool<Component241> _pl0;
EcsPool<Component378> _pl1;
EcsPool<Component47> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component287>().Inc<Component320>().Inc<Component240>().End();
   _p1 = _world.GetPool<Component287>();
   _p2 = _world.GetPool<Component320>();
   _p3 = _world.GetPool<Component240>();
   _pl0 = _world.GetPool<Component241>();
   _pl1 = _world.GetPool<Component378>();
   _pl2 = _world.GetPool<Component47>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System154 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component9> _p1;
EcsPool<Component216> _p2;
EcsPool<Component335> _pl0;
EcsPool<Component228> _pl1;
EcsPool<Component206> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component9>().Inc<Component216>().End();
   _p1 = _world.GetPool<Component9>();
   _p2 = _world.GetPool<Component216>();
   _pl0 = _world.GetPool<Component335>();
   _pl1 = _world.GetPool<Component228>();
   _pl2 = _world.GetPool<Component206>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System155 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component302> _p1;
EcsPool<Component131> _p2;
EcsPool<Component286> _p3;
EcsPool<Component370> _p4;
EcsPool<Component92> _pl0;
EcsPool<Component201> _pl1;
EcsPool<Component99> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component302>().Inc<Component131>().Inc<Component286>().Inc<Component370>().End();
   _p1 = _world.GetPool<Component302>();
   _p2 = _world.GetPool<Component131>();
   _p3 = _world.GetPool<Component286>();
   _p4 = _world.GetPool<Component370>();
   _pl0 = _world.GetPool<Component92>();
   _pl1 = _world.GetPool<Component201>();
   _pl2 = _world.GetPool<Component99>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System156 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component224> _p1;
EcsPool<Component397> _p2;
EcsPool<Component389> _p3;
EcsPool<Component118> _p4;
EcsPool<Component270> _p5;
EcsPool<Component347> _pl0;
EcsPool<Component15> _pl1;
EcsPool<Component326> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component224>().Inc<Component397>().Inc<Component389>().Inc<Component118>().Inc<Component270>().End();
   _p1 = _world.GetPool<Component224>();
   _p2 = _world.GetPool<Component397>();
   _p3 = _world.GetPool<Component389>();
   _p4 = _world.GetPool<Component118>();
   _p5 = _world.GetPool<Component270>();
   _pl0 = _world.GetPool<Component347>();
   _pl1 = _world.GetPool<Component15>();
   _pl2 = _world.GetPool<Component326>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System157 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component104> _p1;
EcsPool<Component197> _p2;
EcsPool<Component107> _pl0;
EcsPool<Component187> _pl1;
EcsPool<Component157> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component104>().Inc<Component197>().End();
   _p1 = _world.GetPool<Component104>();
   _p2 = _world.GetPool<Component197>();
   _pl0 = _world.GetPool<Component107>();
   _pl1 = _world.GetPool<Component187>();
   _pl2 = _world.GetPool<Component157>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System158 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component81> _p1;
EcsPool<Component343> _p2;
EcsPool<Component341> _p3;
EcsPool<Component219> _pl0;
EcsPool<Component238> _pl1;
EcsPool<Component276> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component81>().Inc<Component343>().Inc<Component341>().End();
   _p1 = _world.GetPool<Component81>();
   _p2 = _world.GetPool<Component343>();
   _p3 = _world.GetPool<Component341>();
   _pl0 = _world.GetPool<Component219>();
   _pl1 = _world.GetPool<Component238>();
   _pl2 = _world.GetPool<Component276>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System159 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component389> _p1;
EcsPool<Component380> _p2;
EcsPool<Component125> _p3;
EcsPool<Component29> _p4;
EcsPool<Component285> _p5;
EcsPool<Component88> _pl0;
EcsPool<Component336> _pl1;
EcsPool<Component85> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component389>().Inc<Component380>().Inc<Component125>().Inc<Component29>().Inc<Component285>().End();
   _p1 = _world.GetPool<Component389>();
   _p2 = _world.GetPool<Component380>();
   _p3 = _world.GetPool<Component125>();
   _p4 = _world.GetPool<Component29>();
   _p5 = _world.GetPool<Component285>();
   _pl0 = _world.GetPool<Component88>();
   _pl1 = _world.GetPool<Component336>();
   _pl2 = _world.GetPool<Component85>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System160 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component246> _p1;
EcsPool<Component237> _p2;
EcsPool<Component242> _p3;
EcsPool<Component62> _p4;
EcsPool<Component322> _p5;
EcsPool<Component250> _pl0;
EcsPool<Component122> _pl1;
EcsPool<Component108> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component246>().Inc<Component237>().Inc<Component242>().Inc<Component62>().Inc<Component322>().End();
   _p1 = _world.GetPool<Component246>();
   _p2 = _world.GetPool<Component237>();
   _p3 = _world.GetPool<Component242>();
   _p4 = _world.GetPool<Component62>();
   _p5 = _world.GetPool<Component322>();
   _pl0 = _world.GetPool<Component250>();
   _pl1 = _world.GetPool<Component122>();
   _pl2 = _world.GetPool<Component108>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System161 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component75> _p1;
EcsPool<Component82> _p2;
EcsPool<Component113> _pl0;
EcsPool<Component230> _pl1;
EcsPool<Component31> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component75>().Inc<Component82>().End();
   _p1 = _world.GetPool<Component75>();
   _p2 = _world.GetPool<Component82>();
   _pl0 = _world.GetPool<Component113>();
   _pl1 = _world.GetPool<Component230>();
   _pl2 = _world.GetPool<Component31>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System162 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component89> _p1;
EcsPool<Component144> _p2;
EcsPool<Component328> _pl0;
EcsPool<Component204> _pl1;
EcsPool<Component27> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component89>().Inc<Component144>().End();
   _p1 = _world.GetPool<Component89>();
   _p2 = _world.GetPool<Component144>();
   _pl0 = _world.GetPool<Component328>();
   _pl1 = _world.GetPool<Component204>();
   _pl2 = _world.GetPool<Component27>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System163 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component382> _p1;
EcsPool<Component261> _p2;
EcsPool<Component87> _pl0;
EcsPool<Component269> _pl1;
EcsPool<Component8> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component382>().Inc<Component261>().End();
   _p1 = _world.GetPool<Component382>();
   _p2 = _world.GetPool<Component261>();
   _pl0 = _world.GetPool<Component87>();
   _pl1 = _world.GetPool<Component269>();
   _pl2 = _world.GetPool<Component8>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System164 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component393> _p1;
EcsPool<Component240> _pl0;
EcsPool<Component61> _pl1;
EcsPool<Component326> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component393>().End();
   _p1 = _world.GetPool<Component393>();
   _pl0 = _world.GetPool<Component240>();
   _pl1 = _world.GetPool<Component61>();
   _pl2 = _world.GetPool<Component326>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System165 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component18> _p1;
EcsPool<Component144> _p2;
EcsPool<Component351> _p3;
EcsPool<Component269> _p4;
EcsPool<Component344> _p5;
EcsPool<Component95> _pl0;
EcsPool<Component280> _pl1;
EcsPool<Component231> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component18>().Inc<Component144>().Inc<Component351>().Inc<Component269>().Inc<Component344>().End();
   _p1 = _world.GetPool<Component18>();
   _p2 = _world.GetPool<Component144>();
   _p3 = _world.GetPool<Component351>();
   _p4 = _world.GetPool<Component269>();
   _p5 = _world.GetPool<Component344>();
   _pl0 = _world.GetPool<Component95>();
   _pl1 = _world.GetPool<Component280>();
   _pl2 = _world.GetPool<Component231>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System166 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component233> _p1;
EcsPool<Component119> _p2;
EcsPool<Component163> _p3;
EcsPool<Component194> _pl0;
EcsPool<Component241> _pl1;
EcsPool<Component158> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component233>().Inc<Component119>().Inc<Component163>().End();
   _p1 = _world.GetPool<Component233>();
   _p2 = _world.GetPool<Component119>();
   _p3 = _world.GetPool<Component163>();
   _pl0 = _world.GetPool<Component194>();
   _pl1 = _world.GetPool<Component241>();
   _pl2 = _world.GetPool<Component158>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System167 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component25> _p1;
EcsPool<Component339> _p2;
EcsPool<Component141> _p3;
EcsPool<Component160> _p4;
EcsPool<Component131> _p5;
EcsPool<Component58> _pl0;
EcsPool<Component208> _pl1;
EcsPool<Component263> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component25>().Inc<Component339>().Inc<Component141>().Inc<Component160>().Inc<Component131>().End();
   _p1 = _world.GetPool<Component25>();
   _p2 = _world.GetPool<Component339>();
   _p3 = _world.GetPool<Component141>();
   _p4 = _world.GetPool<Component160>();
   _p5 = _world.GetPool<Component131>();
   _pl0 = _world.GetPool<Component58>();
   _pl1 = _world.GetPool<Component208>();
   _pl2 = _world.GetPool<Component263>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System168 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component155> _p1;
EcsPool<Component192> _p2;
EcsPool<Component314> _p3;
EcsPool<Component241> _p4;
EcsPool<Component129> _p5;
EcsPool<Component268> _pl0;
EcsPool<Component38> _pl1;
EcsPool<Component149> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component155>().Inc<Component192>().Inc<Component314>().Inc<Component241>().Inc<Component129>().End();
   _p1 = _world.GetPool<Component155>();
   _p2 = _world.GetPool<Component192>();
   _p3 = _world.GetPool<Component314>();
   _p4 = _world.GetPool<Component241>();
   _p5 = _world.GetPool<Component129>();
   _pl0 = _world.GetPool<Component268>();
   _pl1 = _world.GetPool<Component38>();
   _pl2 = _world.GetPool<Component149>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System169 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component95> _p1;
EcsPool<Component86> _p2;
EcsPool<Component80> _pl0;
EcsPool<Component230> _pl1;
EcsPool<Component145> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component95>().Inc<Component86>().End();
   _p1 = _world.GetPool<Component95>();
   _p2 = _world.GetPool<Component86>();
   _pl0 = _world.GetPool<Component80>();
   _pl1 = _world.GetPool<Component230>();
   _pl2 = _world.GetPool<Component145>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System170 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component47> _p1;
EcsPool<Component373> _pl0;
EcsPool<Component206> _pl1;
EcsPool<Component317> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component47>().End();
   _p1 = _world.GetPool<Component47>();
   _pl0 = _world.GetPool<Component373>();
   _pl1 = _world.GetPool<Component206>();
   _pl2 = _world.GetPool<Component317>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System171 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component97> _p1;
EcsPool<Component292> _p2;
EcsPool<Component28> _p3;
EcsPool<Component249> _p4;
EcsPool<Component59> _pl0;
EcsPool<Component368> _pl1;
EcsPool<Component300> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component97>().Inc<Component292>().Inc<Component28>().Inc<Component249>().End();
   _p1 = _world.GetPool<Component97>();
   _p2 = _world.GetPool<Component292>();
   _p3 = _world.GetPool<Component28>();
   _p4 = _world.GetPool<Component249>();
   _pl0 = _world.GetPool<Component59>();
   _pl1 = _world.GetPool<Component368>();
   _pl2 = _world.GetPool<Component300>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System172 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component165> _p1;
EcsPool<Component258> _p2;
EcsPool<Component359> _p3;
EcsPool<Component335> _p4;
EcsPool<Component87> _pl0;
EcsPool<Component292> _pl1;
EcsPool<Component188> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component165>().Inc<Component258>().Inc<Component359>().Inc<Component335>().End();
   _p1 = _world.GetPool<Component165>();
   _p2 = _world.GetPool<Component258>();
   _p3 = _world.GetPool<Component359>();
   _p4 = _world.GetPool<Component335>();
   _pl0 = _world.GetPool<Component87>();
   _pl1 = _world.GetPool<Component292>();
   _pl2 = _world.GetPool<Component188>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System173 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component366> _p1;
EcsPool<Component390> _p2;
EcsPool<Component91> _p3;
EcsPool<Component365> _p4;
EcsPool<Component80> _pl0;
EcsPool<Component14> _pl1;
EcsPool<Component102> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component366>().Inc<Component390>().Inc<Component91>().Inc<Component365>().End();
   _p1 = _world.GetPool<Component366>();
   _p2 = _world.GetPool<Component390>();
   _p3 = _world.GetPool<Component91>();
   _p4 = _world.GetPool<Component365>();
   _pl0 = _world.GetPool<Component80>();
   _pl1 = _world.GetPool<Component14>();
   _pl2 = _world.GetPool<Component102>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System174 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component72> _p1;
EcsPool<Component269> _p2;
EcsPool<Component195> _pl0;
EcsPool<Component194> _pl1;
EcsPool<Component93> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component72>().Inc<Component269>().End();
   _p1 = _world.GetPool<Component72>();
   _p2 = _world.GetPool<Component269>();
   _pl0 = _world.GetPool<Component195>();
   _pl1 = _world.GetPool<Component194>();
   _pl2 = _world.GetPool<Component93>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System175 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component158> _p1;
EcsPool<Component252> _p2;
EcsPool<Component291> _pl0;
EcsPool<Component0> _pl1;
EcsPool<Component278> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component158>().Inc<Component252>().End();
   _p1 = _world.GetPool<Component158>();
   _p2 = _world.GetPool<Component252>();
   _pl0 = _world.GetPool<Component291>();
   _pl1 = _world.GetPool<Component0>();
   _pl2 = _world.GetPool<Component278>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System176 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component163> _p1;
EcsPool<Component65> _p2;
EcsPool<Component181> _p3;
EcsPool<Component161> _p4;
EcsPool<Component367> _pl0;
EcsPool<Component118> _pl1;
EcsPool<Component383> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component163>().Inc<Component65>().Inc<Component181>().Inc<Component161>().End();
   _p1 = _world.GetPool<Component163>();
   _p2 = _world.GetPool<Component65>();
   _p3 = _world.GetPool<Component181>();
   _p4 = _world.GetPool<Component161>();
   _pl0 = _world.GetPool<Component367>();
   _pl1 = _world.GetPool<Component118>();
   _pl2 = _world.GetPool<Component383>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System177 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component135> _p1;
EcsPool<Component150> _p2;
EcsPool<Component393> _p3;
EcsPool<Component337> _pl0;
EcsPool<Component356> _pl1;
EcsPool<Component145> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component135>().Inc<Component150>().Inc<Component393>().End();
   _p1 = _world.GetPool<Component135>();
   _p2 = _world.GetPool<Component150>();
   _p3 = _world.GetPool<Component393>();
   _pl0 = _world.GetPool<Component337>();
   _pl1 = _world.GetPool<Component356>();
   _pl2 = _world.GetPool<Component145>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System178 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component383> _p1;
EcsPool<Component114> _p2;
EcsPool<Component352> _pl0;
EcsPool<Component182> _pl1;
EcsPool<Component83> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component383>().Inc<Component114>().End();
   _p1 = _world.GetPool<Component383>();
   _p2 = _world.GetPool<Component114>();
   _pl0 = _world.GetPool<Component352>();
   _pl1 = _world.GetPool<Component182>();
   _pl2 = _world.GetPool<Component83>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System179 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component282> _p1;
EcsPool<Component176> _p2;
EcsPool<Component190> _p3;
EcsPool<Component173> _pl0;
EcsPool<Component105> _pl1;
EcsPool<Component226> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component282>().Inc<Component176>().Inc<Component190>().End();
   _p1 = _world.GetPool<Component282>();
   _p2 = _world.GetPool<Component176>();
   _p3 = _world.GetPool<Component190>();
   _pl0 = _world.GetPool<Component173>();
   _pl1 = _world.GetPool<Component105>();
   _pl2 = _world.GetPool<Component226>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System180 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component100> _p1;
EcsPool<Component107> _pl0;
EcsPool<Component44> _pl1;
EcsPool<Component86> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component100>().End();
   _p1 = _world.GetPool<Component100>();
   _pl0 = _world.GetPool<Component107>();
   _pl1 = _world.GetPool<Component44>();
   _pl2 = _world.GetPool<Component86>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System181 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component326> _p1;
EcsPool<Component139> _pl0;
EcsPool<Component301> _pl1;
EcsPool<Component208> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component326>().End();
   _p1 = _world.GetPool<Component326>();
   _pl0 = _world.GetPool<Component139>();
   _pl1 = _world.GetPool<Component301>();
   _pl2 = _world.GetPool<Component208>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System182 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component397> _p1;
EcsPool<Component361> _p2;
EcsPool<Component30> _p3;
EcsPool<Component269> _p4;
EcsPool<Component10> _p5;
EcsPool<Component322> _pl0;
EcsPool<Component276> _pl1;
EcsPool<Component257> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component397>().Inc<Component361>().Inc<Component30>().Inc<Component269>().Inc<Component10>().End();
   _p1 = _world.GetPool<Component397>();
   _p2 = _world.GetPool<Component361>();
   _p3 = _world.GetPool<Component30>();
   _p4 = _world.GetPool<Component269>();
   _p5 = _world.GetPool<Component10>();
   _pl0 = _world.GetPool<Component322>();
   _pl1 = _world.GetPool<Component276>();
   _pl2 = _world.GetPool<Component257>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System183 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component347> _p1;
EcsPool<Component33> _p2;
EcsPool<Component175> _p3;
EcsPool<Component137> _pl0;
EcsPool<Component338> _pl1;
EcsPool<Component218> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component347>().Inc<Component33>().Inc<Component175>().End();
   _p1 = _world.GetPool<Component347>();
   _p2 = _world.GetPool<Component33>();
   _p3 = _world.GetPool<Component175>();
   _pl0 = _world.GetPool<Component137>();
   _pl1 = _world.GetPool<Component338>();
   _pl2 = _world.GetPool<Component218>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System184 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component72> _p1;
EcsPool<Component281> _p2;
EcsPool<Component288> _p3;
EcsPool<Component391> _pl0;
EcsPool<Component388> _pl1;
EcsPool<Component261> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component72>().Inc<Component281>().Inc<Component288>().End();
   _p1 = _world.GetPool<Component72>();
   _p2 = _world.GetPool<Component281>();
   _p3 = _world.GetPool<Component288>();
   _pl0 = _world.GetPool<Component391>();
   _pl1 = _world.GetPool<Component388>();
   _pl2 = _world.GetPool<Component261>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System185 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component332> _p1;
EcsPool<Component132> _p2;
EcsPool<Component27> _p3;
EcsPool<Component105> _p4;
EcsPool<Component306> _pl0;
EcsPool<Component323> _pl1;
EcsPool<Component30> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component332>().Inc<Component132>().Inc<Component27>().Inc<Component105>().End();
   _p1 = _world.GetPool<Component332>();
   _p2 = _world.GetPool<Component132>();
   _p3 = _world.GetPool<Component27>();
   _p4 = _world.GetPool<Component105>();
   _pl0 = _world.GetPool<Component306>();
   _pl1 = _world.GetPool<Component323>();
   _pl2 = _world.GetPool<Component30>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System186 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component179> _p1;
EcsPool<Component174> _pl0;
EcsPool<Component184> _pl1;
EcsPool<Component355> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component179>().End();
   _p1 = _world.GetPool<Component179>();
   _pl0 = _world.GetPool<Component174>();
   _pl1 = _world.GetPool<Component184>();
   _pl2 = _world.GetPool<Component355>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System187 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component53> _p1;
EcsPool<Component321> _p2;
EcsPool<Component271> _p3;
EcsPool<Component254> _pl0;
EcsPool<Component314> _pl1;
EcsPool<Component315> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component53>().Inc<Component321>().Inc<Component271>().End();
   _p1 = _world.GetPool<Component53>();
   _p2 = _world.GetPool<Component321>();
   _p3 = _world.GetPool<Component271>();
   _pl0 = _world.GetPool<Component254>();
   _pl1 = _world.GetPool<Component314>();
   _pl2 = _world.GetPool<Component315>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System188 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component279> _p1;
EcsPool<Component18> _p2;
EcsPool<Component325> _p3;
EcsPool<Component370> _p4;
EcsPool<Component106> _pl0;
EcsPool<Component267> _pl1;
EcsPool<Component219> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component279>().Inc<Component18>().Inc<Component325>().Inc<Component370>().End();
   _p1 = _world.GetPool<Component279>();
   _p2 = _world.GetPool<Component18>();
   _p3 = _world.GetPool<Component325>();
   _p4 = _world.GetPool<Component370>();
   _pl0 = _world.GetPool<Component106>();
   _pl1 = _world.GetPool<Component267>();
   _pl2 = _world.GetPool<Component219>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System189 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component257> _p1;
EcsPool<Component12> _p2;
EcsPool<Component217> _p3;
EcsPool<Component342> _p4;
EcsPool<Component135> _pl0;
EcsPool<Component69> _pl1;
EcsPool<Component98> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component257>().Inc<Component12>().Inc<Component217>().Inc<Component342>().End();
   _p1 = _world.GetPool<Component257>();
   _p2 = _world.GetPool<Component12>();
   _p3 = _world.GetPool<Component217>();
   _p4 = _world.GetPool<Component342>();
   _pl0 = _world.GetPool<Component135>();
   _pl1 = _world.GetPool<Component69>();
   _pl2 = _world.GetPool<Component98>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System190 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component383> _p1;
EcsPool<Component216> _p2;
EcsPool<Component369> _pl0;
EcsPool<Component334> _pl1;
EcsPool<Component207> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component383>().Inc<Component216>().End();
   _p1 = _world.GetPool<Component383>();
   _p2 = _world.GetPool<Component216>();
   _pl0 = _world.GetPool<Component369>();
   _pl1 = _world.GetPool<Component334>();
   _pl2 = _world.GetPool<Component207>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System191 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component253> _p1;
EcsPool<Component0> _p2;
EcsPool<Component352> _p3;
EcsPool<Component382> _p4;
EcsPool<Component398> _p5;
EcsPool<Component141> _pl0;
EcsPool<Component151> _pl1;
EcsPool<Component10> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component253>().Inc<Component0>().Inc<Component352>().Inc<Component382>().Inc<Component398>().End();
   _p1 = _world.GetPool<Component253>();
   _p2 = _world.GetPool<Component0>();
   _p3 = _world.GetPool<Component352>();
   _p4 = _world.GetPool<Component382>();
   _p5 = _world.GetPool<Component398>();
   _pl0 = _world.GetPool<Component141>();
   _pl1 = _world.GetPool<Component151>();
   _pl2 = _world.GetPool<Component10>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System192 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component77> _p1;
EcsPool<Component72> _pl0;
EcsPool<Component393> _pl1;
EcsPool<Component13> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component77>().End();
   _p1 = _world.GetPool<Component77>();
   _pl0 = _world.GetPool<Component72>();
   _pl1 = _world.GetPool<Component393>();
   _pl2 = _world.GetPool<Component13>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System193 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component207> _p1;
EcsPool<Component56> _p2;
EcsPool<Component399> _p3;
EcsPool<Component39> _p4;
EcsPool<Component104> _pl0;
EcsPool<Component176> _pl1;
EcsPool<Component148> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component207>().Inc<Component56>().Inc<Component399>().Inc<Component39>().End();
   _p1 = _world.GetPool<Component207>();
   _p2 = _world.GetPool<Component56>();
   _p3 = _world.GetPool<Component399>();
   _p4 = _world.GetPool<Component39>();
   _pl0 = _world.GetPool<Component104>();
   _pl1 = _world.GetPool<Component176>();
   _pl2 = _world.GetPool<Component148>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System194 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component357> _p1;
EcsPool<Component242> _p2;
EcsPool<Component220> _p3;
EcsPool<Component150> _pl0;
EcsPool<Component355> _pl1;
EcsPool<Component184> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component357>().Inc<Component242>().Inc<Component220>().End();
   _p1 = _world.GetPool<Component357>();
   _p2 = _world.GetPool<Component242>();
   _p3 = _world.GetPool<Component220>();
   _pl0 = _world.GetPool<Component150>();
   _pl1 = _world.GetPool<Component355>();
   _pl2 = _world.GetPool<Component184>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System195 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component37> _p1;
EcsPool<Component344> _p2;
EcsPool<Component381> _p3;
EcsPool<Component61> _p4;
EcsPool<Component337> _pl0;
EcsPool<Component164> _pl1;
EcsPool<Component324> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component37>().Inc<Component344>().Inc<Component381>().Inc<Component61>().End();
   _p1 = _world.GetPool<Component37>();
   _p2 = _world.GetPool<Component344>();
   _p3 = _world.GetPool<Component381>();
   _p4 = _world.GetPool<Component61>();
   _pl0 = _world.GetPool<Component337>();
   _pl1 = _world.GetPool<Component164>();
   _pl2 = _world.GetPool<Component324>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System196 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component123> _p1;
EcsPool<Component268> _pl0;
EcsPool<Component77> _pl1;
EcsPool<Component102> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component123>().End();
   _p1 = _world.GetPool<Component123>();
   _pl0 = _world.GetPool<Component268>();
   _pl1 = _world.GetPool<Component77>();
   _pl2 = _world.GetPool<Component102>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System197 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component378> _p1;
EcsPool<Component140> _p2;
EcsPool<Component269> _p3;
EcsPool<Component142> _p4;
EcsPool<Component56> _pl0;
EcsPool<Component184> _pl1;
EcsPool<Component328> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component378>().Inc<Component140>().Inc<Component269>().Inc<Component142>().End();
   _p1 = _world.GetPool<Component378>();
   _p2 = _world.GetPool<Component140>();
   _p3 = _world.GetPool<Component269>();
   _p4 = _world.GetPool<Component142>();
   _pl0 = _world.GetPool<Component56>();
   _pl1 = _world.GetPool<Component184>();
   _pl2 = _world.GetPool<Component328>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System198 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component217> _p1;
EcsPool<Component329> _p2;
EcsPool<Component230> _p3;
EcsPool<Component30> _p4;
EcsPool<Component193> _p5;
EcsPool<Component86> _pl0;
EcsPool<Component43> _pl1;
EcsPool<Component110> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component217>().Inc<Component329>().Inc<Component230>().Inc<Component30>().Inc<Component193>().End();
   _p1 = _world.GetPool<Component217>();
   _p2 = _world.GetPool<Component329>();
   _p3 = _world.GetPool<Component230>();
   _p4 = _world.GetPool<Component30>();
   _p5 = _world.GetPool<Component193>();
   _pl0 = _world.GetPool<Component86>();
   _pl1 = _world.GetPool<Component43>();
   _pl2 = _world.GetPool<Component110>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

class System199 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component247> _p1;
EcsPool<Component186> _p2;
EcsPool<Component366> _p3;
EcsPool<Component123> _pl0;
EcsPool<Component396> _pl1;
EcsPool<Component132> _pl2;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component247>().Inc<Component186>().Inc<Component366>().End();
   _p1 = _world.GetPool<Component247>();
   _p2 = _world.GetPool<Component186>();
   _p3 = _world.GetPool<Component366>();
   _pl0 = _world.GetPool<Component123>();
   _pl1 = _world.GetPool<Component396>();
   _pl2 = _world.GetPool<Component132>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
