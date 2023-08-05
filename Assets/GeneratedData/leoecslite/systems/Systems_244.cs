using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System244 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component372> _p1;
EcsPool<Component442> _p2;
EcsPool<Component280> _p3;
EcsPool<Component328> _p4;
EcsPool<Component87> _pl0;
EcsPool<TicksCooldownComponent> _pt;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component372>().Inc<Component442>().Inc<Component280>().Inc<Component328>().End();
   _p1 = _world.GetPool<Component372>();
   _p2 = _world.GetPool<Component442>();
   _p3 = _world.GetPool<Component280>();
   _p4 = _world.GetPool<Component328>();
   _pt = _world.GetPool<TicksCooldownComponent>();
   _pl0 = _world.GetPool<Component87>();
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
