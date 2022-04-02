using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System146 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component480> _p1;
EcsPool<Component39> _p2;
EcsPool<Component65> _p3;
EcsPool<Component298> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component480>().Inc<Component39>().Inc<Component65>().Inc<Component298>().End();
   _p1 = _world.GetPool<Component480>();
   _p2 = _world.GetPool<Component39>();
   _p3 = _world.GetPool<Component65>();
   _p4 = _world.GetPool<Component298>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
