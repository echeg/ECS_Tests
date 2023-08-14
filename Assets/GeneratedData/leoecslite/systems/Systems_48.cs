using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System48 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component331> _p1;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component331>().End();
   _p1 = _world.GetPool<Component331>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
