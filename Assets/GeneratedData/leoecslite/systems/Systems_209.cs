using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System209 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component245> _p1;
EcsPool<Component254> _p2;
EcsPool<Component41> _p3;
EcsPool<Component279> _p4;
EcsPool<Component294> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component245>().Inc<Component254>().Inc<Component41>().Inc<Component279>().End();
   _p1 = _world.GetPool<Component245>();
   _p2 = _world.GetPool<Component254>();
   _p3 = _world.GetPool<Component41>();
   _p4 = _world.GetPool<Component279>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component294>();
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
