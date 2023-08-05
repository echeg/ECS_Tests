using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System65 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component480> _p1;
EcsPool<Component338> _p2;
EcsPool<Component94> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component480>().Inc<Component338>().Inc<Component94>().End();
   _p1 = _world.GetPool<Component480>();
   _p2 = _world.GetPool<Component338>();
   _p3 = _world.GetPool<Component94>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
