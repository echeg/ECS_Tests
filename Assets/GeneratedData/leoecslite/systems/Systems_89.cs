using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System89 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component352> _p1;
EcsPool<Component298> _p2;
EcsPool<Component353> _p3;
EcsPool<Component67> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component352>().Inc<Component298>().Inc<Component353>().Inc<Component67>().End();
   _p1 = _world.GetPool<Component352>();
   _p2 = _world.GetPool<Component298>();
   _p3 = _world.GetPool<Component353>();
   _p4 = _world.GetPool<Component67>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
