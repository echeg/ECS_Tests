using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System18 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component198> _p1;
EcsPool<Component34> _p2;
EcsPool<Component424> _p3;
EcsPool<Component151> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component198>().Inc<Component34>().Inc<Component424>().Inc<Component151>().End();
   _p1 = _world.GetPool<Component198>();
   _p2 = _world.GetPool<Component34>();
   _p3 = _world.GetPool<Component424>();
   _p4 = _world.GetPool<Component151>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
