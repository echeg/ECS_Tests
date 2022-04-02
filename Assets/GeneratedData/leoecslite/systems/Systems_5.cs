using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System5 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component468> _p1;
EcsPool<Component249> _p2;
EcsPool<Component350> _p3;
EcsPool<Component236> _p4;
EcsPool<Component144> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component468>().Inc<Component249>().Inc<Component350>().Inc<Component236>().End();
   _p1 = _world.GetPool<Component468>();
   _p2 = _world.GetPool<Component249>();
   _p3 = _world.GetPool<Component350>();
   _p4 = _world.GetPool<Component236>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component144>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
   var e = _world.NewEntity();
   ref var c1 = ref _pl0.Add(e);
   ref var tick = ref _pt.Add(e);
   tick.Ticks=10;
  }
 }
}

}
