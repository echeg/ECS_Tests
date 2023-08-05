using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System34 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component498> _p1;
EcsPool<Component47> _p2;
EcsPool<Component127> _p3;
EcsPool<Component364> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component498>().Inc<Component47>().Inc<Component127>().Inc<Component364>().End();
   _p1 = _world.GetPool<Component498>();
   _p2 = _world.GetPool<Component47>();
   _p3 = _world.GetPool<Component127>();
   _p4 = _world.GetPool<Component364>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
